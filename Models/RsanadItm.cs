using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class RsanadItm
    {
        public long RNo { get; set; }
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

        public virtual Rsanad RNoNavigation { get; set; } = null!;
    }
}
