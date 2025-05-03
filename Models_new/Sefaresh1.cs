using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class Sefaresh1
    {
        public Sefaresh1()
        {
            Sefaresh2s = new HashSet<Sefaresh2>();
        }

        public int S1No { get; set; }
        public byte S1Mrkaz { get; set; }
        public string S1Date { get; set; } = null!;
        public string? S1Vahed { get; set; }
        public bool S1Kind { get; set; }
        public int S1User { get; set; }
        public string? S1Foroshande { get; set; }

        public virtual ICollection<Sefaresh2> Sefaresh2s { get; set; }
    }
}
