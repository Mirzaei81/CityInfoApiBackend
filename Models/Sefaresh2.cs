using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Sefaresh2
    {
        public int S2No { get; set; }
        public short S2Radif { get; set; }
        public int S2Kala { get; set; }
        public double S2Num { get; set; }
        public string? S2Shrh { get; set; }
        public string? S2DateR { get; set; }
        public byte S2Kind { get; set; }
        public double? S2Num2 { get; set; }
        public string? S2DateE { get; set; }

        public virtual Kala S2KalaNavigation { get; set; } = null!;
        public virtual Sefaresh1 S2NoNavigation { get; set; } = null!;
    }
}
