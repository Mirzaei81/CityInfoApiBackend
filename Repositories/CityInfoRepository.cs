using CityInfoApi.Dtos;
using CityInfoApi.Models_new;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Transactions;

namespace CityInfoApi.Repositories
{
    public class CityInfoRepository : iCityInfoReposit
    {
        private readonly AlmasACC14031Context _dbcontex;
        private readonly PersianCalendar pc;
        private readonly TransactionOptions transactionOption;
        private SqlTransaction transaction;
        public CityInfoRepository(AlmasACC14031Context dbcontex)
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
                .Where(F => F.F1.FNo == FK_NO).Select(a => new FactorDetail(a.K.KCode, a.K.KName, a.F2.FkNumKoli??0, a.K.KZarib??0, a.K.KVahed, a.F2.FkNum??0, a.F2.FkMab??0, a.F2.FkMab??0 * a.F2.FkNum??0)).ToArrayAsync();
        }
        private async Task<long> genrateF_NO(long loginId,string tmpName,int count,string today)
        {
            long F_No = await _dbcontex.Factor1s.OrderByDescending(F=>-1*F.FNo).Select(F => F.FNo).LastOrDefaultAsync();

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
        private async void ExitFromReserv(string Chr, long no)
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
        private async Task<long> ins2Factor(FactorSubmit factorSubmition)
        {

            var maxFNo = await _dbcontex.Factor1s
                .MaxAsync(f =>f.FNo);
            int fNo = maxFNo + 1;

            int maxFFactor = await _dbcontex.Factor1s.MaxAsync(f => f.FFactor);
            long  newFFactor = (maxFFactor) + 1;

            DateTime thisDate = DateTime.Now;
            string timeU = thisDate.ToString("H-m");
            PersianCalendar pc = new PersianCalendar();

            string dateU = String.Format("{2}/{1}/{0}",
                      pc.GetYear(thisDate),
                      pc.GetMonth(thisDate),
                      pc.GetDayOfMonth(thisDate));


            long mFactor = -1;
            double? mab = factorSubmition.FactorDetails.Sum(f => f.FkMab);
            double? mabKol = factorSubmition.FactorDetails.Sum(f => f.FkMabKoli);

            await _dbcontex.Database.ExecuteSqlRawAsync("" +
                "INSERT INTO [Factor1] ([F_Factor], [F_Anbar], [F_Date], [F_DateU], [F_Kind], [F_Moshtari],[F_Porsant], [F_Mrkaz], [F_No],    [F_TimeU], [F_User])" +
                "VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);",
    newFFactor, 1, dateU,  dateU, 20, factorSubmition.FPorsant, 1,fNo, timeU, factorSubmition.LoginId
                );
            await _dbcontex.SaveChangesAsync();

            return newFFactor;
        }
        public async Task str_Ins2FactorITM(FactorSubmit factorSubmition,long mFactor)
        {
            int cnt = 0;
            foreach (FactorDetail row in factorSubmition.FactorDetails)
            {
                cnt += 1;
                Factor2 item = new Factor2
                {
                    FkFactor = (int)mFactor,
                    FkRadif = cnt,
                    FkKala = row.KCode,
                    FkNum = row.FkNum,
                    FkNumKoli = (byte)row.FkNumkoli,
                    FkTol = 0,
                    FkArze = 0,
                    FkV = 0,
                    FkTdad = 0,
                    FkMab = row.FkMab,
                    FkKindArz = 0,
                    FkArz = 0,
                    FkModat = false,
                    FkDateModat = "",
                    FkSharh = cnt == 0 ? factorSubmition.Sharh : "",
                    FkKdarsad = 0,
                    FkMaliat = 0,
                    FkAvarez = 0,
                };
                await _dbcontex.Factor2s.AddAsync(item);
            }
            await _dbcontex.SaveChangesAsync();

        }
        public async Task<long> SubmitFactorAsync(FactorSubmit factorSubmition)
        {
            long F_Factor = -1;
            long mFactor = -1;
            double? mab = factorSubmition.FactorDetails.Sum(f => f.FkMab);
            double? mabKol = factorSubmition.FactorDetails.Sum(f => f.FkMabKoli);
            SqlConnection connection =new SqlConnection(_dbcontex.Database.GetConnectionString());
            F_Factor = await ins2Factor(factorSubmition);
            await str_Ins2FactorITM(factorSubmition,F_Factor);

            await connection.OpenAsync();
            transaction = connection.BeginTransaction();
            string tmpName = "##" + _dbcontex.Database.GetDbConnection().Database + "F20";
            ExitFromReserv("F20", F_Factor);
            await connection.CloseAsync();
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
