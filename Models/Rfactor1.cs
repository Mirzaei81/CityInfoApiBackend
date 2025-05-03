using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Rfactor1
    {
        public long RNo { get; set; }
        public long FFactor { get; set; }
        public long FNo { get; set; }
        public byte FKind { get; set; }
        public byte FMrkaz { get; set; }
        public string FDate { get; set; } = null!;
        public byte FAnbar { get; set; }
        public long FMoshtari { get; set; }
        public long FSerial { get; set; }
        public string? FDateTahvil { get; set; }
        public double? FMab { get; set; }
        public double? FMabKol { get; set; }
        public long FPorsant { get; set; }
        public double? FMabPorsant { get; set; }
        public byte? FKindPay { get; set; }
        public long? FNoPay { get; set; }
        public long FSanad { get; set; }
        public bool? FFlag { get; set; }
        public string? FDateA { get; set; }
        public byte? FUser { get; set; }
        public string? FTimeU { get; set; }
        public string? FDateU { get; set; }
        public double? FKosor { get; set; }
        public double? FEzafat { get; set; }
        public byte? FAnbar2 { get; set; }
        public string? FAccKosorat { get; set; }
        public string? FAccEzafat { get; set; }
        public bool? FFixKosorat { get; set; }
        public bool? FFixEzafat { get; set; }
        public bool? FFixPorsant { get; set; }
        public long FPrlong { get; set; }
        public bool? FKdarsad { get; set; }
        public string? FAccAnbar { get; set; }
        public double? FMaliat { get; set; }
        public double? FAvarez { get; set; }
        public string? FDriverName { get; set; }
    }
}
