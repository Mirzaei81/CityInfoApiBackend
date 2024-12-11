using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models
{
    public partial class SysYear
    {
        public int YDaftar { get; set; }
        public int YYear { get; set; }
        public int YCompany { get; set; }
        [JsonIgnore]
        public string? YDateF { get; set; }

        [JsonIgnore]
        public string? YDateE { get; set; }
        public string? YDbname { get; set; }
        [JsonIgnore]
        public bool? YFlag { get; set; }
        [JsonIgnore]
        public int? YFirstSanad { get; set; }
        [JsonIgnore]
        public int? YLastSanad { get; set; }
        [JsonIgnore]
        public double? YMaliat { get; set; }
        [JsonIgnore]
        public double? YAvarez { get; set; }

        public virtual SysCompany YCompanyNavigation { get; set; } = null!;
        public virtual SysDaftar YDaftarNavigation { get; set; } = null!;
    }
}
