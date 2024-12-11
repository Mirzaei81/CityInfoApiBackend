using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class InEditFactor
    {
        public int FFactor { get; set; }
        public int? User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Factor1 FFactorNavigation { get; set; } = null!;
    }
}
