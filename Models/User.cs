using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models
{
    [Index(nameof(UName),IsUnique =true)]
    public partial class User
    {
        public int UNo { get; set; }
        public string UName { get; set; } = null!;
        [JsonIgnore]
        public string URamz { get; set; } = null!;
        public byte UKind { get; set; }
        public bool UAdd { get; set; }
        public bool UDele { get; set; }
        public bool UEsla { get; set; }
        public bool UList { get; set; }
        public bool? UAddDb { get; set; }
        public bool? UDelDb { get; set; }
        public string UTimeF { get; set; } = null!;
        public string UTimeE { get; set; } = null!;
        public string UDateL { get; set; } = null!;
        public string? UHgd { get; set; }
        public bool UActive { get; set; }
    }
}
