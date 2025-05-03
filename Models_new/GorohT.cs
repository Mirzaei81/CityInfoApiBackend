using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class GorohT
    {
        public GorohT()
        {
            KCodes = new HashSet<Kala>();
        }

        public int TCode { get; set; }
        public string? TName { get; set; }

        public virtual ICollection<Kala> KCodes { get; set; }
    }
}
