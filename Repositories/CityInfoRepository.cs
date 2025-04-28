using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Immutable;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Transactions;

namespace CityInfoApi.Repositories
{
    public class CityInfoRepository : iCityInfoReposit
    {
        private readonly AlmasACC _dbcontex;
        private readonly PersianCalendar pc;
        private readonly TransactionOptions transactionOption;
        private SqlTransaction transaction;
        public CityInfoRepository(AlmasACC dbcontex)
        {
            _dbcontex = dbcontex;
            pc = new PersianCalendar();
            transactionOption = new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted,
                Timeout = TransactionManager.MaximumTimeout,
            };
        }

        public async Task<IEnumerable<Kala>> GetKalasAsync()
        {
            return await _dbcontex.Kalas.ToListAsync();
        }

        public async Task<IEnumerable<Moshtari>> GetMoshtarisAsync()
        {
            return await _dbcontex.Moshtaris.ToListAsync();
        }

        public async Task<IEnumerable<Factor1>> GetFactor1sAsync()
        {
            return await _dbcontex.Factor1s.Include(f1 => f1.Factor2s).ToListAsync();
        }


        public async Task<IEnumerable<Factor1>> GetFactor1sWithFactor2Async(int id)
        {

            return await _dbcontex.Factor1s.Include(f1 => f1.Factor2s)
                                                             .Where(f1 => f1.FMoshtari == id)
                                                           .ToListAsync();
        }

        public async Task<IEnumerable<HsbPrsnsKoli>> GetHsbPrsnsKoliAsync(string dateTo, string dateFrom, int codeM, int mrkaz, int mandDate, char kind)
        {
            var queryResult = await _dbcontex.HsbPrsnsKolis.FromSqlInterpolated($@"EXEC acc_HsbPrsnsKoli {dateTo}, {dateFrom}, {codeM}, {mrkaz}, {mandDate}, {kind}").ToListAsync();
            return queryResult;
        }
        public async Task<IEnumerable<Sanad1400>> Getacc_SelectSanadsAsync(int code, string date1)
        {
            var queryResult = await _dbcontex.Sanad1400s.FromSqlInterpolated($@"
           EXEC acc_SelectSanads1 {code},{date1} 
       ").ToListAsync();

            return queryResult;
        }
        public async Task<IEnumerable<categoryDTO?>> GetCategoriesAsync()
        {
            return await _dbcontex.GorohKs.Select(g => new categoryDTO(g.GkCode, g.GkName!)).ToArrayAsync();
        }

        public async Task<IEnumerable<Kala>> GetKalaByGroupAsync(int GId, int anbar, string ToDate)
        {
            return await _dbcontex.Kalas.Where(k => k.KGoroh == GId).ToArrayAsync();
        }
        public async Task<IEnumerable<Anbar>> GetAnbarsAsync()
        {
            return await _dbcontex.Anbars.ToListAsync();
        }

        public async Task<IEnumerable<FactorDetail>> GetFactorDetailsAsync(int FK_NO)
        {
            return await _dbcontex.Factor1s.Join(_dbcontex.Factor2s, F1 => F1.FFactor, F2 => F2.FkFactor, (F1, F2) => new { F1, F2 })
                .Join(_dbcontex.Kalas, a => a.F2.FkKala, k => k.KCode, (a, k) => new { F1 = a.F1, F2 = a.F2, K = k })
                .Where(F => F.F1.FNo == FK_NO).Select(a => new FactorDetail(a.K.KCode, a.K.KName, a.F2.FkNumKoli, a.K.KZarib, a.K.KVahed, a.F2.FkNum, a.F2.FkMab, a.F2.FkMab * a.F2.FkNum)).ToArrayAsync();
        }
        private async Task<int> genrateF_NO(long loginId,string tmpName,int count,string today)
        {
            int F_No = await _dbcontex.Factor1s.OrderByDescending(F=>-1*F.FNo).Select(F => F.FNo).LastOrDefaultAsync();

            string dbName = tmpName;
            if (F_No == default)
            {
                F_No = 1;
            }
            else
            {
                F_No += count;
            }
            dbName+= F_No;
            try
            {
                await _dbcontex.Database.ExecuteSqlRawAsync("Create Table " + dbName + " ([User] int, DateTime datetime ); " + " Insert Into " +dbName+ " Values ( " + loginId + ", "+today+")");
            }
            catch (SqlException ex)
            {
                await genrateF_NO(loginId,tmpName,count + 1,today);
            }
            return F_No;
        }
        private async void ExitFromReserv(string Chr, int no)
        {
            using (SqlCommand dropCommand = new SqlCommand(" Drop Table " + "##" + _dbcontex.Database.GetDbConnection().Database.ToString() + Chr + no))
            {
                try
                {
                    await dropCommand.ExecuteNonQueryAsync();
                }
                catch (Exception ex) { }
            }

        }
        public async Task<int> SubmitFactorAsync(FactorSubmit factorSubmition)
        {
            int F_Factor = -1;
            int mFactor = -1;
            double? mab = factorSubmition.FactorDetails.Sum(f => f.FkMab);
            double? mabKol = factorSubmition.FactorDetails.Sum(f => f.FkMabKoli);
            SqlConnection connection =new SqlConnection(_dbcontex.Database.GetConnectionString());
            await connection.OpenAsync();
            transaction = connection.BeginTransaction();
            string tmpName = "##" + _dbcontex.Database.GetDbConnection().Database + "F20";
            DateTime today = DateTime.Now;
            string  todayPersian = String.Format("{0}/{1}/{2}",pc.GetYear(today),pc.GetMonth(today),pc.GetDayOfMonth(today));
            F_Factor = await genrateF_NO(factorSubmition.LoginId,tmpName,1,todayPersian);
            using (SqlCommand cmdInsHdr = new SqlCommand("str_Ins2Factor"))
            {
                cmdInsHdr.Connection = connection;
                cmdInsHdr.Transaction = transaction;
                cmdInsHdr.CommandType = CommandType.StoredProcedure;
                cmdInsHdr.Parameters.AddWithValue("@F_No", F_Factor);
                cmdInsHdr.Parameters.AddWithValue("@F_Date", todayPersian);
                cmdInsHdr.Parameters.AddWithValue("@F_Markz", factorSubmition.FMarkz);
                cmdInsHdr.Parameters.AddWithValue("@F_User", factorSubmition.LoginId);
                cmdInsHdr.Parameters.AddWithValue("@F_Kind", 20);
                cmdInsHdr.Parameters.AddWithValue("@F_Anbar", factorSubmition.Anbar);
                cmdInsHdr.Parameters.AddWithValue("@F_Moshtari", factorSubmition.MoshtaryId);
                cmdInsHdr.Parameters.AddWithValue("@F_Anbar2", DBNull.Value);
                cmdInsHdr.Parameters.AddWithValue("@F_Serial", DBNull.Value);
                cmdInsHdr.Parameters.AddWithValue("@F_DateTahvil", "");
                cmdInsHdr.Parameters.AddWithValue("@F_DateA", "");
                cmdInsHdr.Parameters.AddWithValue("@F_Mab", mab);
                cmdInsHdr.Parameters.AddWithValue("@F_Kosor", 0);
                cmdInsHdr.Parameters.AddWithValue("@F_Ezafat", 0);
                cmdInsHdr.Parameters.AddWithValue("@F_MabKol", mabKol);
                cmdInsHdr.Parameters.AddWithValue("@F_Porsant", DBNull.Value);
                cmdInsHdr.Parameters.AddWithValue("@F_MabPorsant", DBNull.Value);
                cmdInsHdr.Parameters.AddWithValue("@F_FixPorsant", false);
                cmdInsHdr.Parameters.AddWithValue("@F_Kdarsad", false);
                cmdInsHdr.Parameters.AddWithValue("@F_Avarez", 0);
                cmdInsHdr.Parameters.AddWithValue("@F_Maliat", 0);
                cmdInsHdr.Parameters.AddWithValue("@F_DriverName", "");
                cmdInsHdr.Parameters.AddWithValue("@F_AccAnbar", DBNull.Value); // txtAcc2.Text
                var mFactorReturn = cmdInsHdr.Parameters.Add("@ReturnVal", SqlDbType.Int);
                mFactorReturn.Direction = ParameterDirection.ReturnValue;
                try
                {
                    cmdInsHdr.ExecuteNonQuery();
                    mFactor =(int)mFactorReturn.Value;
                    if (mFactor == -1)
                    {
                        await transaction.RollbackAsync();
                        throw new NullReferenceException("new Factor Id wasn't created check sql logs");
                    }
                }
                catch (SqlException expcep) { 
                    ExitFromReserv("F20", F_Factor);
                    throw expcep;
                }
            }

            int cnt = 0;
            foreach (FactorDetail row in factorSubmition.FactorDetails)
            {
                cnt += 1;
                using (SqlCommand cmdInsITM = new SqlCommand("Str_ins2factorITM"))
                {
                    cmdInsITM.Transaction = transaction;
                    cmdInsITM.Connection =connection;
                    cmdInsITM.CommandType = CommandType.StoredProcedure;
                    cmdInsITM.Parameters.AddWithValue("@F_Factor", mFactor);
                    cmdInsITM.Parameters.AddWithValue("@Radif", cnt);
                    cmdInsITM.Parameters.AddWithValue("@Kala", row.KCode);
                    cmdInsITM.Parameters.AddWithValue("@Sharh", cnt == 0 ? factorSubmition.Sharh :""); 
                    cmdInsITM.Parameters.AddWithValue("@Num", row.FkNum);
                    cmdInsITM.Parameters.AddWithValue("@NumKoli", row.FkNumkoli);
                    cmdInsITM.Parameters.AddWithValue("@Tol", 0);
                    cmdInsITM.Parameters.AddWithValue("@Arze", 0);
                    cmdInsITM.Parameters.AddWithValue("@V", 0);
                    cmdInsITM.Parameters.AddWithValue("@Tdad", 0);
                    cmdInsITM.Parameters.AddWithValue("@Mab", row.FkMab);
                    cmdInsITM.Parameters.AddWithValue("@KindArz", DBNull.Value);
                    cmdInsITM.Parameters.AddWithValue("@Arz", DBNull.Value);
                    cmdInsITM.Parameters.AddWithValue("@Modat", DBNull.Value);
                    cmdInsITM.Parameters.AddWithValue("@DateModat", "");
                    cmdInsITM.Parameters.AddWithValue("@Anbar", factorSubmition.Anbar);
                    cmdInsITM.Parameters.AddWithValue("@Anbar2", -1);
                    cmdInsITM.Parameters.AddWithValue("@Kdarsad", DBNull.Value);
                    cmdInsITM.Parameters.AddWithValue("@Avarez", DBNull.Value);
                    cmdInsITM.Parameters.AddWithValue("@Maliat", DBNull.Value);
                    cmdInsITM.ExecuteNonQuery();
                }
            }
            await transaction.CommitAsync();
            await connection.CloseAsync();
            connection.Dispose();
            connection = null;
            ExitFromReserv("F20", F_Factor);
            return F_Factor;
        }
        public async Task<Moshtari> CreateMoshtariAsync(MoshtariDto moshtariDto)
        {
            var moshtari = new Moshtari
            {
                MGoroh = moshtariDto.MGoroh,
                MName = moshtariDto.MName,
                MAcc = "",
                MKol = "",
                MMoein = "",
                MTfzili = "",
                MModir = false,
                MAtbar = moshtariDto.MAtbar,
                MMobil = moshtariDto.MMobil,
                MAddress = moshtariDto.MAddress,
                MMeli = moshtariDto.MMeli,
                MHmkar = moshtariDto.MHmkar,
                MPost = moshtariDto.MPost,
                MCity = moshtariDto.MCity,
                MOstan = moshtariDto.MOstan
            };

            _dbcontex.Moshtaris.Add(moshtari);
            await _dbcontex.SaveChangesAsync();
            return moshtari;
        }
        public async Task<IEnumerable<Kala>> GetKalaByGroupAsync(int GId)
        {
            return await  _dbcontex.Kalas.Where(k => k.KGoroh == GId).ToListAsync();
        }

        public async Task<IEnumerable<GorohM>> GetGorohMsAsync()
        {
            return await  _dbcontex.GorohMs.ToListAsync();
        }
    }
}
