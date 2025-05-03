using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Rpayment1
    {
        public long RNo { get; set; }
        public byte? P1Markaz { get; set; }
        public byte P1Kind { get; set; }
        public long P1No { get; set; }
        public string P1Date { get; set; } = null!;
        public long P1Moshtari { get; set; }
        public long P1Sanad { get; set; }
        public bool P1IsArz { get; set; }
        public long P1User { get; set; }
        public string? P1DateU { get; set; }
        public string? P1TimeU { get; set; }
        public double? P1Sum { get; set; }
        public string? P1Acc1 { get; set; }
        public string? P1Acc2 { get; set; }
    }
}
