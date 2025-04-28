using CityInfoApi.Dtos;
using CityInfoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Repositories.Interfaces
{
    public interface iCityInfoReposit
    {
        Task<IEnumerable<Kala>> GetKalasAsync();
        
        Task<IEnumerable<Kala>> GetKalaByGroupAsync(int GId);
        Task<IEnumerable<categoryDTO?>> GetCategoriesAsync();
        Task<IEnumerable<Moshtari>> GetMoshtarisAsync();
        Task<IEnumerable<FactorDetail>> GetFactorDetailsAsync(int FK_NO);

        Task<IEnumerable<Factor1>> GetFactor1sAsync();

        Task<IEnumerable<Factor1>> GetFactor1sWithFactor2Async(int id);

        Task<IEnumerable<HsbPrsnsKoli>> GetHsbPrsnsKoliAsync(string dateTo, string dateFrom, int codeM, int mrkaz, int mandDate, char kind);

        Task<IEnumerable<Sanad1400>> Getacc_SelectSanadsAsync(int code, string date1);
        Task<IEnumerable<Anbar>> GetAnbarsAsync();
        Task<int> SubmitFactorAsync(FactorSubmit factorDetail);
        Task<Moshtari> CreateMoshtariAsync(MoshtariDto moshtariDto);
        Task<IEnumerable<GorohM>> GetGorohMsAsync();
    }
}
