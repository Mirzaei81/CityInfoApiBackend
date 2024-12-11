using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class KalaT
    {
        public int TKala { get; set; }
        public int TRadif { get; set; }
        public int? TKalaItm { get; set; }
        public double? TNum { get; set; }
        public double? TMab { get; set; }

        public virtual Kala? TKalaItmNavigation { get; set; }
        public virtual Kala TKalaNavigation { get; set; } = null!;
    }
}
