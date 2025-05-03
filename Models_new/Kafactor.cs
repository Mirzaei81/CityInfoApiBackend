using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class Kafactor
    {
        public Kafactor()
        {
            KafactorLs = new HashSet<KafactorL>();
        }

        public string KaFactor1 { get; set; } = null!;
        public string? KaName { get; set; }
        public bool? KaKind { get; set; }
        public double? KaDarsad { get; set; }
        public double? KaSabet { get; set; }
        public string? KaAcc { get; set; }

        public virtual Onvan? KaAccNavigation { get; set; }
        public virtual ICollection<KafactorL> KafactorLs { get; set; }
    }
}
