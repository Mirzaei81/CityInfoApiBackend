using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Rpayment2
    {
        public long? RNo { get; set; }
        public byte P2Kind { get; set; }
        public long P2No { get; set; }
        public int P2Radif { get; set; }
        public byte? P2KindP { get; set; }
        public int? P2Check { get; set; }
        public string? P2Acc { get; set; }
        public string? P2Shrh { get; set; }
        public double? P2Mab { get; set; }
        public string? P2Acc2 { get; set; }
        public double? P2ArzMab { get; set; }
        public byte? P2ArzType { get; set; }
        public short? P2KindC { get; set; }
        public double? P2ArzKol { get; set; }

        public virtual Rpayment1? RNoNavigation { get; set; }
    }
}
