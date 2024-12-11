using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class Kala
    {
        public Kala()
        {
            Factor2s = new HashSet<Factor2>();
            KalaMs = new HashSet<KalaM>();
            KalaTTKalaItmNavigations = new HashSet<KalaT>();
            KalaTTKalaNavigations = new HashSet<KalaT>();
            Sefaresh2s = new HashSet<Sefaresh2>();
            TCodes = new HashSet<GorohT>();
        }

        public int KCode { get; set; }
        public int KGoroh { get; set; }
        public string? KName { get; set; }
        public string? KVahed { get; set; }
        public string? KVahedKoli { get; set; }
        public double? KZarib { get; set; }
        public double? KForoshM { get; set; }
        public byte? KArz { get; set; }
        public double? KArzMab { get; set; }
        public double? KMinF { get; set; }
        public double? KMaxF { get; set; }
        public double? KForoshH { get; set; }
        public string? KFani { get; set; }
        public string? KSharh { get; set; }
        public byte[]? KPic { get; set; }
        public bool? KLog { get; set; }
        public byte? KLan { get; set; }
        public string? KNameL { get; set; }
        public double? KTolid { get; set; }
        public double? KHtolid { get; set; }
        public double? KSarbar { get; set; }
        public double? KHtmam { get; set; }
        public string? KBarcode { get; set; }
        public double? KOmde { get; set; }
        public double? KVazn { get; set; }
        public double? KDarsad { get; set; }
        public string? KKeshvar { get; set; }
        public double? KFmonth { get; set; }
        public double? KFyear { get; set; }
        public double? KFmonth2 { get; set; }
        public double? KFmonth3 { get; set; }
        public double? KFmonth4 { get; set; }
        public double? KFmonth1 { get; set; }
        public double? KFmonth5 { get; set; }
        public double? KFmonth6 { get; set; }
        public double? KFmonth7 { get; set; }
        public double? KFmonth8 { get; set; }
        public double? KFmonth9 { get; set; }
        public double? KFmonth10 { get; set; }
        public double? KFmonth11 { get; set; }
        public double? KFmonth12 { get; set; }
        public bool? KMaliatIs { get; set; }
        public double? KMaliat { get; set; }
        public bool? KAvarezIs { get; set; }
        public double? KAvarez { get; set; }
        public string? KFani2 { get; set; }
        public double? KPorsant { get; set; }
        public bool? KIsBarcode { get; set; }
        public long? KForoshN { get; set; }
        public long? KForoshMd { get; set; }
        public long? KForoshMsrf { get; set; }

        public virtual GorohK KGorohNavigation { get; set; } = null!;
        public virtual ICollection<Factor2> Factor2s { get; set; }
        public virtual ICollection<KalaM> KalaMs { get; set; }
        public virtual ICollection<KalaT> KalaTTKalaItmNavigations { get; set; }
        public virtual ICollection<KalaT> KalaTTKalaNavigations { get; set; }
        public virtual ICollection<Sefaresh2> Sefaresh2s { get; set; }

        public virtual ICollection<GorohT> TCodes { get; set; }
    }
}
