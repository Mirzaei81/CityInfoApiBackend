using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfoApi.Models_new
{
    public partial class Onvan
    {
        public Onvan()
        {
            AnbarAAcc11Navigations = new HashSet<Anbar>();
            AnbarAAcc12Navigations = new HashSet<Anbar>();
            AnbarAAcc13Navigations = new HashSet<Anbar>();
            AnbarAAcc14Navigations = new HashSet<Anbar>();
            AnbarAAcc16Navigations = new HashSet<Anbar>();
            AnbarAAcc19Navigations = new HashSet<Anbar>();
            AnbarAAcc1Navigations = new HashSet<Anbar>();
            AnbarAAcc22Navigations = new HashSet<Anbar>();
            AnbarAAcc23Navigations = new HashSet<Anbar>();
            AnbarAAcc24Navigations = new HashSet<Anbar>();
            AnbarAAcc2Navigations = new HashSet<Anbar>();
            AnbarAAcc3Navigations = new HashSet<Anbar>();
            AnbarAAcc4Navigations = new HashSet<Anbar>();
            AnbarAAcc5Navigations = new HashSet<Anbar>();
            AnbarAAcc6Navigations = new HashSet<Anbar>();
            AnbarAAcc7Navigations = new HashSet<Anbar>();
            AnbarAAcc9Navigations = new HashSet<Anbar>();
            CheckCHesab2Navigations = new HashSet<Check>();
            CheckCHesabNavigations = new HashSet<Check>();
            Factor1FAccEzafatNavigations = new HashSet<Factor1>();
            Factor1FAccKosoratNavigations = new HashSet<Factor1>();
            Kafactors = new HashSet<Kafactor>();
            Khadamats = new HashSet<Khadamat>();
            Moshtaris = new HashSet<Moshtari>();
            Payment1P1Acc1Navigations = new HashSet<Payment1>();
            Payment1P1Acc2Navigations = new HashSet<Payment1>();
            Payment2P2Acc2Navigations = new HashSet<Payment2>();
            Payment2P2AccNavigations = new HashSet<Payment2>();
            SanadItms = new HashSet<SanadItm>();
        }

        [Key]
        public byte? OGoroh { get; set; }
        public string? OKol { get; set; }
        public string? OMoein { get; set; }
        public string? OTfzili { get; set; }
        public string OAcc { get; set; } = null!;
        public string? OName { get; set; }
        public bool OSub { get; set; }
        public long? OBed { get; set; }
        public long? OBes { get; set; }
        public double? OArzBed { get; set; }
        public double? OArzBes { get; set; }
        public int? OSanad { get; set; }
        public int OKind { get; set; }
        public bool? OTemp { get; set; }
        public bool? OInUsed { get; set; }
        public bool? OFlag { get; set; }
        public short? ONoDarayi { get; set; }
        public byte? OBedBes { get; set; }

        public virtual Goroh? OGorohNavigation { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc11Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc12Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc13Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc14Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc16Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc19Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc1Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc22Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc23Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc24Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc2Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc3Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc4Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc5Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc6Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc7Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Anbar> AnbarAAcc9Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Check> CheckCHesab2Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Check> CheckCHesabNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<Factor1> Factor1FAccEzafatNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<Factor1> Factor1FAccKosoratNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<Kafactor> Kafactors { get; set; }
        [NotMapped]
        public virtual ICollection<Khadamat> Khadamats { get; set; }
        [NotMapped]
        public virtual ICollection<Moshtari> Moshtaris { get; set; }
        [NotMapped]
        public virtual ICollection<Payment1> Payment1P1Acc1Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Payment1> Payment1P1Acc2Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Payment2> Payment2P2Acc2Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Payment2> Payment2P2AccNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<SanadItm> SanadItms { get; set; }
    }
}
