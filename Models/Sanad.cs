using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Sanad
    {
        public Sanad()
        {
            Factor1s = new HashSet<Factor1>();
            Khadamats = new HashSet<Khadamat>();
            Payment1s = new HashSet<Payment1>();
            SanadItms = new HashSet<SanadItm>();
        }

        public int SNo { get; set; }
        public int SSanad { get; set; }
        public string? SDate { get; set; }
        public byte? SMarkaz { get; set; }
        public bool SFlag { get; set; }
        public int? SUser { get; set; }
        public string? STimeU { get; set; }
        public string? SDateU { get; set; }
        public bool? STemp { get; set; }
        public int? SPrint { get; set; }
        public bool SInEdit { get; set; }
        public bool SIsArz { get; set; }
        public string? SType { get; set; }

        public virtual InEditSanad InEditSanad { get; set; } = null!;
        public virtual ICollection<Factor1> Factor1s { get; set; }
        public virtual ICollection<Khadamat> Khadamats { get; set; }
        public virtual ICollection<Payment1> Payment1s { get; set; }
        public virtual ICollection<SanadItm> SanadItms { get; set; }
    }
}
