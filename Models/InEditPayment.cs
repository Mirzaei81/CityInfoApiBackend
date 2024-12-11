using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class InEditPayment
    {
        public byte P1Kind { get; set; }
        public long P1No { get; set; }
        public int? User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Payment1 P1 { get; set; } = null!;
    }
}
