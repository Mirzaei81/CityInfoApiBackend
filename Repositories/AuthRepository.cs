using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CityInfoApi.Repositories
{
    internal class AuthRepository : IAuth
    {
        private readonly AlmasMainContext _context;
        public AuthRepository(AlmasMainContext ctx)
        {
            _context = ctx; 
        }

        public async Task<string?> GetConfigDBAsync(float yearId, string daftarName, string companyName)
        {
            string? sysYear =await  (from year in _context.Set<SysYear>()
                               join daftar in _context.Set<SysDaftar>()
                                   on year.YDaftar equals daftar.DId
                               join company in _context.Set<SysCompany>()
                                   on year.YCompany equals company.CId
                                where year.YYear == yearId && daftar.DName == daftarName && company.CName == companyName
                               select year.YDbname).FirstOrDefaultAsync();
            return sysYear;
        }

        public async Task<UserResault?> GetUserAsync(string username,string password)
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.UName == username);

            if (user != null) {
                if (Equals(Encrypt(password),user.URamz))
                {
                    IQueryable<ServerDetail> serverDetail = from year in _context.Set<SysYear>()
                                                  join daftar in _context.Set<SysDaftar>()
                                                      on year.YDaftar equals daftar.DId
                                                  join company in _context.Set<SysCompany>()
                                                      on year.YCompany equals company.CId
                                                  select new ServerDetail(daftar.DName, year.YYear, company.CName,year.YDbname);
                    UserResault userDetail = new(user, await serverDetail.ToArrayAsync());
                    return userDetail;
                }
                return null;
            }
            return null;
        }

        public async Task<string[]?> GetAllUserAsync()
        {
            return await _context.Users.Select(U=>U.UName).ToArrayAsync();
        }


        private string Encrypt(string password)
        {
            String Hashed = "";
            for(int i = 0; i < password.Length; i++)
            {
                Hashed += (char)(password[i] + 2 * i - 8);
            }
           return Hashed; 
        }

    }
}
