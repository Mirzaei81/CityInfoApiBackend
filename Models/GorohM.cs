using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models
{
    public partial class GorohM
    {
        public GorohM()
        {
            Moshtaris = new HashSet<Moshtari>();
        }

        public int GmCode { get; set; }
        public string? GmName { get; set; }
        public bool? GmInKharid { get; set; }
        public bool? GmInForosh { get; set; }
        public bool? GmInPosnt { get; set; }

        [JsonIgnore]
        public virtual ICollection<Moshtari> Moshtaris { get; set; }
    }
}
