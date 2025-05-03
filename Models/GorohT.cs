using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class GorohT
    {
        public GorohT()
        {
            KCodes = new HashSet<Kala>();
        }

        [Key]
        public long TCode { get; set; }
        public string? TName { get; set; }

        public virtual ICollection<Kala> KCodes { get; set; }
    }
}
