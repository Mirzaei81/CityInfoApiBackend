using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class InEditSefaresh
    {
        public long S1No { get; set; }
        public long User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Sefaresh1 S1NoNavigation { get; set; } = null!;
    }
}
