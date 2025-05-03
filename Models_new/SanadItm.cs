using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class SanadItm
    {
        public SanadItm()
        {
            Checks = new HashSet<Check>();
        }

        public int SSanad { get; set; }
        public int Radif { get; set; }
        public string Acc { get; set; } = null!;
        public string? Sharh { get; set; }
        public double Bed { get; set; }
        public double? ArzBed { get; set; }
        public double Bes { get; set; }
        public double? ArzBes { get; set; }
        public byte? ACode { get; set; }
        public int? FFactor { get; set; }
        public long? PPayment { get; set; }
        public byte? PKind { get; set; }
        public int? HHesab { get; set; }
        public long? KhKhadamat { get; set; }
        public double? ArzKol { get; set; }
        public int? BBar { get; set; }

        public virtual Onvan AccNavigation { get; set; } = null!;
        public virtual Factor1? FFactorNavigation { get; set; }
        public virtual Khadamat? KhKhadamatNavigation { get; set; }
        public virtual Payment1? P { get; set; }
        public virtual Sanad SSanadNavigation { get; set; } = null!;
        public virtual ICollection<Check> Checks { get; set; }
    }
}
