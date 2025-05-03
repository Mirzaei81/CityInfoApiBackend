using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class Ghest
    {
        public int GhMoshtari { get; set; }
        public int GhNo { get; set; }
        public string GhDate { get; set; } = null!;
        public double? GhMab { get; set; }
        public string GhDateV { get; set; } = null!;
        public string? GhShrh { get; set; }
        public long? GhPayment { get; set; }
        public string? GhCodemeli { get; set; }
        public string? GhDatevam { get; set; }
        public int? GhMabkolvam { get; set; }
        public string? GhVamacc { get; set; }
    }
}
