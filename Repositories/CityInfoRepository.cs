using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace CityInfoApi.Repositories
{
    public class CityInfoRepository : iCityInfoReposit
    {
        private readonly AlmasACC _dbcontex;
        public CityInfoRepository(AlmasACC dbcontex)
        {
            _dbcontex = dbcontex;
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

        /* public async Task<IEnumerable<str_Ins2Factor>> Getstr_Ins2FactorAsync(string dateTo, string dateFrom, int codeM, int mrkaz, int mandDate, char kind)
         {
             var queryResult = await _dbcontex.str_Ins2Factor.FromSqlInterpolated($@"
            EXEC str_Ins2Factor {dateTo}, {dateFrom}, {codeM}, {mrkaz}, {mandDate}, {kind}").ToListAsync();

             return queryResult;
         }*/


        /*        public async Task<IEnumerable<output>> Getoutput(Input input)
                {
                    string StoredProc = "exec CreateAppointment " +
                            "@ClinicID = " + input.ClinicId + "," +
                            "@AppointmentDate = '" + input.AppointmentDate + "'," +
                            "@FirstName= '" + input.FirstName + "'," +
                            "@LastName= '" + input.LastName + "'," +
                            "@PatientID= " + input.PatientId + "," +
                            "@AppointmentStartTime= '" + input.AppointmentStartTime + "'," +
                            "@AppointmentEndTime= '" + input.AppointmentEndTime + "'";

                    //return await _context.output.ToListAsync();
                    return await _context.output.FromSqlRaw(StoredProc).ToListAsync();
                }*/

        public async Task<IEnumerable<Sanad1400>> Getacc_SelectSanadsAsync(int code, string date1)
        {
            var queryResult = await _dbcontex.Sanad1400s.FromSqlInterpolated($@"
           EXEC acc_SelectSanads1 {code},{date1} 
       ").ToListAsync();

            return queryResult;
        }

        public async Task<IEnumerable<Ins2Factor>> GetQueryResult(int F_No,
                        string F_Date, int F_Markz,
                        int F_User,
                        short F_Kind,
                        short F_Anbar,
                        int F_Moshtari,
                        int F_Serial,
                        short F_Anbar2,
                        string F_DateTahvil,
                        string F_DateA,
                        float F_Mab,
                        float F_MabKol,
                        float F_Kosor,
                        float F_Ezafat,
                        int F_Porsant,
                        float F_MabPorsant,
                        byte F_FixPorsant, byte F_Kdarsad,
                        string F_AccAnbar,
                        float F_Maliat, float F_Avarez,
                        string F_DriverName)

        /* public async Task<IEnumerable<Ins2Factor>> GetQueryResult(int F_No,
                   string F_Date, int F_Markz,
                   int F_User,
                   short F_Kind,
                   short F_Anbar,
                   int F_Moshtari,
                   float F_Mab,
                   float F_MabKol)*/
        {
            /*
                        var queryResult = await _dbcontex.Ins2factor.FromSqlInterpolated($@"
                             exec str_Ins2Factor 
                             {F_No},
                             {F_Date},
                             {F_Markz},
                             {F_User},
                             {F_Kind},
                             {F_Anbar},
                             {F_Moshtari},
                             {F_Mab},
                             {F_MabKol}").ToListAsync();*/

            var queryResult = await _dbcontex.Ins2factor.FromSqlInterpolated($@"
                 exec str_Ins2Factor 
                 {F_No},
                 {F_Date},
                 {F_Markz},
                 {F_User},
                 {F_Kind},
                 {F_Anbar},
                 {F_Moshtari},
                 {F_Serial},
                 {F_Anbar2},
                 {F_DateTahvil},
                 {F_DateA},
                 {F_Mab},
                 {F_MabKol},
                 {F_Kosor},
                 {F_Ezafat},
                 {F_Porsant},
                 {F_MabPorsant},
                 {F_FixPorsant},
                 {F_Kdarsad},
                 {F_AccAnbar},
                 {F_Maliat},
                 {F_Avarez},
                 {F_DriverName}").ToListAsync();


            /*   var queryResult = await _dbcontex.Ins2factor.FromSqlInterpolated($@"
                      exec str_Ins2Factor 
                      @F_No=85,
                      @F_Date='1401/03/19',
                      @F_Markz=1,
                      @F_User=16,
                      @F_Kind=20,
                      @F_Anbar=1,
                      @F_Moshtari=10001,
                      @F_Serial=NULL,
                      @F_Anbar2=NULL,
                      @F_DateTahvil='____/__/__',
                      @F_DateA='          ',
                      @F_Mab=2500,
                      @F_MabKol=2500,
                      @F_Kosor=0,
                      @F_Ezafat=0,
                      @F_Porsant=NULL,
                      @F_MabPorsant=NULL,
                      @F_FixPorsant=0,
                      @F_Kdarsad=0,
                      @F_AccAnbar=NULL,
                      @F_Maliat=0,
                      @F_Avarez=0,
                      @F_DriverName=N''").ToListAsync();*/

            return queryResult;
        }

        public async Task<IEnumerable<categoryDTO?>> GetCategoriesAsync()
        {
            return await _dbcontex.GorohKs.Select(g => new categoryDTO(g.GkCode, g.GkName!)).ToArrayAsync();
        }

        public async Task<IEnumerable<Kala>> GetKalaByGroupAsync(int GId)
        {
            return await _dbcontex.Kalas.Join(_dbcontex.GorohKs, k => k.KGoroh, g => g.GkCode, (K, G) => new { K, G }).Where((a) => a.G.GkCode == GId).Select(a => a.K).ToArrayAsync();
        }

        public async Task<IEnumerable<FactorDetail>> GetFactorDetailsAsync(int FK_NO)
        {
            return await _dbcontex.Factor1s.Join(_dbcontex.Factor2s, F1 => F1.FFactor, F2 => F2.FkFactor, (F1, F2) => new { F1, F2 })
                .Join(_dbcontex.Kalas,a=>a.F2.FkKala,k=>k.KCode,(a,k)=> new { F1 = a.F1, F2 = a.F2, K = k })
                .Where(F => F.F1.FNo == FK_NO).Select(a=>new FactorDetail(a.K.KCode,a.K.KName,a.F2.FkNumKoli,a.K.KZarib,a.K.KVahed,a.F2.FkNum,a.F2.FkMab,a.F2.FkMab*a.F2.FkTdad)).ToArrayAsync();
        }

    }
}

