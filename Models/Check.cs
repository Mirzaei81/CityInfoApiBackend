using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Check
    {
        public Check()
        {
            Payment2s = new HashSet<Payment2>();
        }

        public long CCheck { get; set; }
        public string? CDateC { get; set; }
        public string? CBank { get; set; }
        public string? CShobeh { get; set; }
        public string? CNoJary { get; set; }
        public double? CMab { get; set; }
        public double? CArzMab { get; set; }
        public byte? CArzType { get; set; }
        public string? CDateV { get; set; }
        public short? CKind { get; set; }
        public bool? CFlag { get; set; }
        public string? CSharh { get; set; }
        public long CSanad { get; set; }
        public long CRadif { get; set; }
        public string? CName { get; set; }
        public string? CHesab { get; set; }
        public string? CHesab2 { get; set; }
        public bool? CShahrestan { get; set; }
        public byte? CPrsnCheck { get; set; }

        public virtual SanadItm? C { get; set; }
        public virtual Onvan? CHesab2Navigation { get; set; }
        public virtual Onvan? CHesabNavigation { get; set; }
        public virtual ICollection<Payment2> Payment2s { get; set; }
    }
}
