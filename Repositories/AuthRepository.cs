using CityInfoApi.AlmasMain;
using CityInfoApi.Dtos;
using CityInfoApi.Models_new;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CityInfoApi.Repositories
{
    internal class AuthRepository : IAuth
    {
        private readonly AlmasMainContext _context;
        public AuthRepository(AlmasMainContext ctx)
        {
            _context = ctx; 
        }

        public async Task<ConfigDto?> GetConfigDBAsync(float yearId, string daftarName, string companyName)
        {
            ConfigDto? configResult =await  (from year in _context.Set<SysYear>()
                               join daftar in _context.Set<SysDaftar>()
                                   on year.YDaftar equals daftar.DId
                               join company in _context.Set<SysCompany>()
                                   on year.YCompany equals company.CId
                                where year.YYear == yearId && daftar.DName == daftarName && company.CName == companyName
                               select new ConfigDto ( year.YDbname!,year.YDateE!,year.YDateF! )).FirstOrDefaultAsync();
            return configResult;
        }

        public async Task<UserResault?> GetUserAsync(string username,string password)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.UName == username);
            if (user != null) {
                if (Equals(Encrypt(password),user.URamz))
                {
                    IEnumerable<ServerDetail> serverDetail = await (from year in _context.Set<SysYear>()
                                                  join daftar in _context.Set<SysDaftar>()
                                                      on year.YDaftar equals daftar.DId
                                                  join company in _context.Set<SysCompany>()
                                                      on year.YCompany equals company.CId
                                                  select new ServerDetail(daftar.DName!, year.YYear, company.CName!,year.YDbname!)).ToArrayAsync();
                    UserResault userDetail = new(user, serverDetail);
                    IEnumerable<Markaz> markazes = await  _context.Markazs.ToListAsync();
                    userDetail.markazes= markazes;
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
