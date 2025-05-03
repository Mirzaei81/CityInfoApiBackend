using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class KafactorL
    {
        public int LFactor { get; set; }
        public string LKa { get; set; } = null!;
        public double? LDarsad { get; set; }
        public double? LSabet { get; set; }

        public virtual Factor1 LFactorNavigation { get; set; } = null!;
        public virtual Kafactor LKaNavigation { get; set; } = null!;
    }
}
