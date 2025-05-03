using System;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models_new
{
    public partial class SysYear
    {
        public long YDaftar { get; set; }
        public long YYear { get; set; }
        public long YCompany { get; set; }
        [JsonIgnore]
        public string? YDateF { get; set; }

        [JsonIgnore]
        public string? YDateE { get; set; }
        public string? YDbname { get; set; }
        [JsonIgnore]
        public bool? YFlag { get; set; }
        [JsonIgnore]
        public long YFirstSanad { get; set; }
        [JsonIgnore]
        public long YLastSanad { get; set; }
        [JsonIgnore]
        public double? YMaliat { get; set; }
        [JsonIgnore]
        public double? YAvarez { get; set; }

        public virtual SysCompany YCompanyNavigation { get; set; } = null!;
        public virtual SysDaftar YDaftarNavigation { get; set; } = null!;
    }
}
