using CityInfoApi.Dtos;
using CityInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfoApi.Repositories.Interfaces
{
    public interface IAuth
    {
        public Task<UserResault?> GetUserAsync(string user,string password);
        public Task<ConfigDto?> GetConfigDBAsync(float year, string daftar, string company);
        Task<string[]?> GetAllUserAsync();
    }
}
