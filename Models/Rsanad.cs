using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Rsanad
    {
        public long RNo { get; set; }
        public int SNo { get; set; }
        public int SSanad { get; set; }
        public string SDate { get; set; } = null!;
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
    }
}
