using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class KalaM
    {
        public int KmCode { get; set; }
        public byte KmAnbar { get; set; }
        public double? KmMojKol { get; set; }
        public double? KmMoj { get; set; }
        public double? KmArzesh { get; set; }
        public double? KmMinMoj { get; set; }
        public double? KmSefaresh { get; set; }
        public string? KmRadif { get; set; }
        public double? KmShomaresh { get; set; }
        public double? KmEndMoj { get; set; }
        public double? KmEndMojKol { get; set; }
        public double? KmEndArzesh { get; set; }
        public long? KmLastArzesh { get; set; }
        public double? KmArzArzesh { get; set; }
        public double? KmEndArzArzesh { get; set; }
        public long? KmLastArzArzesh { get; set; }
        public double? KmMaxMoj { get; set; }
        public byte? KmKindArz { get; set; }
        public string? KKeshvar { get; set; }

        public virtual Anbar KmAnbarNavigation { get; set; } = null!;
        public virtual Kala KmCodeNavigation { get; set; } = null!;
    }
}
