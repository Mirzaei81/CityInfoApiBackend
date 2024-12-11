using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class InEditSefaresh
    {
        public int S1No { get; set; }
        public int? User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Sefaresh1 S1NoNavigation { get; set; } = null!;
    }
}
