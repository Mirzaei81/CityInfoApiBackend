using CityInfoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Repositories.Interfaces
{
    public interface iCityInfoReposit
    {
        Task<IEnumerable<Kala>> GetKalasAsync();

        Task<IEnumerable<Moshtari>> GetMoshtarisAsync();

        Task<IEnumerable<Factor1>> GetFactor1sAsync();

        Task<IEnumerable<Factor1>> GetFactor1sWithFactor2Async(int id);

        Task<IEnumerable<HsbPrsnsKoli>> GetHsbPrsnsKoliAsync(string dateTo, string dateFrom, int codeM, int mrkaz, int mandDate, char kind);

        Task<IEnumerable<Sanad1400>> Getacc_SelectSanadsAsync(int code, string date1);




        Task<IEnumerable<Ins2Factor>> GetQueryResult(int F_No,
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
                   string F_DriverName);
        /*
                Task<IEnumerable<Ins2Factor>> GetQueryResult(int F_No,
                                string F_Date, int F_Markz,
                                int F_User,
                                short F_Kind,
                                short F_Anbar,
                                int F_Moshtari,
                                float F_Mab,
                                float F_MabKol);*/



    }
}
