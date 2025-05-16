using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfoApi.Models_new
{
    public partial class Factor1
    {
        public Factor1()
        {
            Factor2s = new HashSet<Factor2>();
            KafactorLs = new HashSet<KafactorL>();
            SanadItms = new HashSet<SanadItm>();
        }

        public int FFactor { get; set; }
        public int FNo { get; set; }
        public byte FKind { get; set; }
        public byte FMrkaz { get; set; }
        public string FDate { get; set; } = null!;
        public byte FAnbar { get; set; }
        public int? FMoshtari { get; set; }
        public int? FSerial { get; set; }
        public string? FDateTahvil { get; set; }
        public double? FMab { get; set; }
        public double? FMabKol { get; set; }
        public int? FPorsant { get; set; }
        public double? FMabPorsant { get; set; }
        public byte? FKindPay { get; set; }
        public long? FNoPay { get; set; }
        public int? FSanad { get; set; }
        public bool? FFlag { get; set; }
        public string? FDateA { get; set; }
        public byte? FUser { get; set; }
        public string? FTimeU { get; set; }
        public string? FDateU { get; set; }
        public double? FKosor { get; set; }
        public double? FEzafat { get; set; }
        public byte? FAnbar2 { get; set; }
        public string? FAccKosorat { get; set; }
        public string? FAccEzafat { get; set; }
        public bool? FFixKosorat { get; set; }
        public bool? FFixEzafat { get; set; }
        public bool? FFixPorsant { get; set; }
        public int? FPrint { get; set; }
        public bool? FKdarsad { get; set; }
        public string? FAccAnbar { get; set; }
        public double? FMaliat { get; set; }
        public double? FAvarez { get; set; }
        public string? FDriverName { get; set; }
        public string? FUid { get; set; }
        public string? FRef { get; set; }
        public string? FLog { get; set; }
        public string? FTaxId { get; set; }

        public virtual Payment1? F { get; set; }

        [NotMapped]
        public virtual Onvan? FAccEzafatNavigation { get; set; }

        [NotMapped]
        public virtual Onvan? FAccKosoratNavigation { get; set; }
        public virtual Anbar? FAnbar2Navigation { get; set; }
        public virtual Anbar FAnbarNavigation { get; set; } = null!;
        public virtual Moshtari? FMoshtariNavigation { get; set; }
        public virtual Moshtari? FPorsantNavigation { get; set; }
        public virtual Sanad? FSanadNavigation { get; set; }
        public virtual InEditFactor InEditFactor { get; set; } = null!;
        public virtual ICollection<Factor2> Factor2s { get; set; }
        [NotMapped]
        public virtual ICollection<KafactorL> KafactorLs { get; set; }
        [NotMapped]
        public virtual ICollection<SanadItm> SanadItms { get; set; }
    }
}
