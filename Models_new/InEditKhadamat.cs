using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class InEditKhadamat
    {
        public long KhNo { get; set; }
        public int? User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Khadamat KhNoNavigation { get; set; } = null!;
    }
}
