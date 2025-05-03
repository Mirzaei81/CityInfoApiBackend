using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class GorohM
    {
        public GorohM()
        {
            Moshtaris = new HashSet<Moshtari>();
        }

        public int GmCode { get; set; }
        public string? GmName { get; set; }
        public bool? GmInKharid { get; set; }
        public bool? GmInForosh { get; set; }
        public bool? GmInPosnt { get; set; }

        public virtual ICollection<Moshtari> Moshtaris { get; set; }
    }
}
