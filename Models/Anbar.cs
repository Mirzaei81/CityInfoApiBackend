using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Anbar
    {
        public Anbar()
        {
            Factor1FAnbar2Navigations = new HashSet<Factor1>();
            Factor1FAnbarNavigations = new HashSet<Factor1>();
            KalaMs = new HashSet<KalaM>();
        }

        public long ACode { get; set; }
        public string? AName { get; set; }
        public string? ANameA { get; set; }
        public bool? AFlag { get; set; }
        public virtual ICollection<Factor1> Factor1FAnbar2Navigations { get; set; }
        public virtual ICollection<Factor1> Factor1FAnbarNavigations { get; set; }
        public virtual ICollection<KalaM> KalaMs { get; set; }
    }
}
