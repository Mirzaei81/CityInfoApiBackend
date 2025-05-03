using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class GorohK
    {
        public GorohK()
        {
            Kalas = new HashSet<Kala>();
        }

        [Key]
        public int GkCode { get; set; }
        public string? GkName { get; set; }
        public bool? GkInKharid { get; set; }
        public bool? GkInForosh { get; set; }
        public bool? GkInKhadmat { get; set; }

        public virtual ICollection<Kala> Kalas { get; set; }
    }
}
