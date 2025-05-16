using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfoApi.Models_new
{
    public partial class Anbar
    {
        public Anbar()
        {
            Factor1FAnbar2Navigations = new HashSet<Factor1>();
            Factor1FAnbarNavigations = new HashSet<Factor1>();
            KalaMs = new HashSet<KalaM>();
        }

        public byte ACode { get; set; }
        public string? AName { get; set; }
        public string? ANameA { get; set; }
        public bool? AFlag { get; set; }
        public string? AAcc1 { get; set; }
        public string? AAcc2 { get; set; }
        public string? AAcc3 { get; set; }
        public string? AAcc4 { get; set; }
        public string? AAcc5 { get; set; }
        public string? AAcc6 { get; set; }
        public string? AAcc9 { get; set; }
        public string? AAcc10 { get; set; }
        public string? AAcc11 { get; set; }
        public string? AAcc12 { get; set; }
        public string? AAcc13 { get; set; }
        public string? AAcc14 { get; set; }
        public string? AAcc19 { get; set; }
        public string? AAcc22 { get; set; }
        public string? AAcc23 { get; set; }
        public string? AAcc24 { get; set; }
        public string? AAcc7 { get; set; }
        public string? AAcc16 { get; set; }

        [NotMapped]
        public virtual Onvan MAccNavigation { get; set; } = null!;
        [NotMapped]
        public virtual Onvan? AAcc10Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc11Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc12Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc13Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc14Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc16Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc19Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc1Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc22Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc23Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc24Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc2Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc3Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc4Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc5Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc6Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc7Navigation { get; set; }
        [NotMapped]
        public virtual Onvan? AAcc9Navigation { get; set; }
        [NotMapped]
        public virtual ICollection<Factor1> Factor1FAnbar2Navigations { get; set; }
        [NotMapped]
        public virtual ICollection<Factor1> Factor1FAnbarNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<KalaM> KalaMs { get; set; }
    }
}
