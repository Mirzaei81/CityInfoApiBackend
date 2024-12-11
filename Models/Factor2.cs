using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models
{
    public partial class Factor2
    {
        public int FkFactor { get; set; }
        public int FkRadif { get; set; }
        public int? FkKala { get; set; }
        public double? FkNum { get; set; }
        public int? FkNumKoli { get; set; }
        public double? FkTol { get; set; }
        public double? FkArze { get; set; }
        public byte? FkV { get; set; }
        public short? FkTdad { get; set; }
        public double? FkMab { get; set; }
        public byte? FkKindArz { get; set; }
        public double? FkArz { get; set; }
        public bool? FkModat { get; set; }
        public string? FkDateModat { get; set; }
        public string? FkSharh { get; set; }
        public double? FkKdarsad { get; set; }
        public double? FkMaliat { get; set; }
        public double? FkAvarez { get; set; }

        [JsonIgnore]
        public virtual Factor1 FkFactorNavigation { get; set; } = null!;
        public virtual Kala? FkKalaNavigation { get; set; }
    }
}
