using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Khadamat
    {
        public Khadamat()
        {
            SanadItms = new HashSet<SanadItm>();
        }

        public byte KhMarkaz { get; set; }
        public long KhNo { get; set; }
        public string KhDate { get; set; } = null!;
        public long? KhMoshtari { get; set; }
        public string? KhMname { get; set; }
        public long KhSanad { get; set; }
        public long KhUser { get; set; }
        public string? KhDateU { get; set; }
        public string? KhTimeU { get; set; }
        public string? KhSerial { get; set; }
        public string? KhShrh { get; set; }
        public string? KhAcc { get; set; }
        public string? KhShrh2 { get; set; }
        public string? KhKind { get; set; }
        public string? KhMotealegh { get; set; }
        public string? KhSerial2 { get; set; }
        public long KhFactor { get; set; }
        public string? KhDateF { get; set; }
        public string? KhDateG { get; set; }
        public double? KhOjrat { get; set; }
        public double? KhGhatat { get; set; }
        public double? KhSum { get; set; }
        public long? KhNoPay { get; set; }
        public byte? KhKindPay { get; set; }
        public string? KhDateT { get; set; }
        public string? KhKalaName { get; set; }

        public virtual Payment1? Kh { get; set; }
        public virtual Onvan? KhAccNavigation { get; set; }
        public virtual Moshtari? KhMoshtariNavigation { get; set; }
        public virtual Sanad? KhSanadNavigation { get; set; }
        public virtual ICollection<SanadItm> SanadItms { get; set; }
    }
}
