using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Sm
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = null!;
        public string CreateTime { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string? Txt { get; set; }
        public string? Type { get; set; }
        public string? SendDate { get; set; }
        public string? SendTime { get; set; }
        public string? Status { get; set; }
        public string? DeliverDate { get; set; }
        public string? DeliverTime { get; set; }
        public string? DeliverStatus { get; set; }
        public string? DeliverMessage { get; set; }
    }
}
