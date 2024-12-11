using CityInfoApi.Models;

namespace CityInfoApi.Dtos
{
    public class UserResault
    {
        public User user { get; set; }
        public ServerDetail[] serverDetail { get; set; }
        public UserResault(User matchedUser, ServerDetail[] detail )
        {
            user = matchedUser;
            serverDetail = detail;
        }
    }
    public class ServerDetail
    {
        public string YDaftar { get; set; }
        public int YYear{ get; set; }
        public string YCompany{ get; set; }
        public string YDbname { get; set; }

        public ServerDetail(string Daftar,  int years, string companies, string yDbname)
        {
            YDaftar = Daftar;
            YYear = years;
            YCompany = companies;
            YDbname = yDbname;
        }
    }
}
