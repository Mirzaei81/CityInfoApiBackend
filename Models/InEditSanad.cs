using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class InEditSanad
    {
        [Key]
        public long SSanad { get; set; }
        public long User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Sanad SSanadNavigation { get; set; } = null!;
    }
}
