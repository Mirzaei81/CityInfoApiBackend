using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfoApi.Dtos
{
    public class categoryDTO
    {
        public long id { get; set; }
        public string name { get; set; }= String.Empty;
        public categoryDTO(long Gid,string Gname)
        {
            id = Gid;
            name = Gname;
        }

    }
}
