using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class InEditKhadamat
    {
        [Key]
        public long KhNo { get; set; }
        public long User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Khadamat KhNoNavigation { get; set; } = null!;
    }
}
