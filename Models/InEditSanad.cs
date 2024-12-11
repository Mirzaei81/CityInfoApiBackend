using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class InEditSanad
    {
        public int SSanad { get; set; }
        public int? User { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Sanad SSanadNavigation { get; set; } = null!;
    }
}
