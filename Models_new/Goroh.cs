using System;
using System.Collections.Generic;

namespace CityInfoApi.Models_new
{
    public partial class Goroh
    {
        public Goroh()
        {
            Onvans = new HashSet<Onvan>();
        }

        public byte GhCode { get; set; }
        public string GhName { get; set; } = null!;
        public int GhKind { get; set; }
        public int GhMahiat { get; set; }

        public virtual ICollection<Onvan> Onvans { get; set; }
    }
}
