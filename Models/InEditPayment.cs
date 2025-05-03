using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class InEditPayment
    {
        [Key]
        public byte P1Kind { get; set; }
        public long P1No { get; set; }
        public long User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Payment1 P1 { get; set; } = null!;
    }
}
