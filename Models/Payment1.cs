using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Payment1
    {
        public Payment1()
        {
            Factor1s = new HashSet<Factor1>();
            InEditPayments = new HashSet<InEditPayment>();
            Khadamats = new HashSet<Khadamat>();
            Payment2s = new HashSet<Payment2>();
            SanadItms = new HashSet<SanadItm>();
        }

        public byte? P1Markaz { get; set; }
        public byte P1Kind { get; set; }
        public long P1No { get; set; }
        public string P1Date { get; set; } = null!;
        public long P1Moshtari { get; set; }
        public long P1Sanad { get; set; }
        public bool? P1IsArz { get; set; }
        public long P1User { get; set; }
        public string? P1DateU { get; set; }
        public string? P1TimeU { get; set; }
        public double? P1Sum { get; set; }
        public string? P1Acc1 { get; set; }
        public string? P1Acc2 { get; set; }

        public virtual Onvan? P1Acc1Navigation { get; set; }
        public virtual Onvan? P1Acc2Navigation { get; set; }
        public virtual Moshtari? P1MoshtariNavigation { get; set; }
        public virtual Sanad? P1SanadNavigation { get; set; }
        public virtual ICollection<Factor1> Factor1s { get; set; }
        public virtual ICollection<InEditPayment> InEditPayments { get; set; }
        public virtual ICollection<Khadamat> Khadamats { get; set; }
        public virtual ICollection<Payment2> Payment2s { get; set; }
        public virtual ICollection<SanadItm> SanadItms { get; set; }
    }
}
