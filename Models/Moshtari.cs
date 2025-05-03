using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityInfoApi.Models
{
    public partial class Moshtari
    {
        public Moshtari()
        {
            Factor1FMoshtariNavigations = new HashSet<Factor1>();
            Factor1FPorsantNavigations = new HashSet<Factor1>();
            Khadamats = new HashSet<Khadamat>();
            Payment1s = new HashSet<Payment1>();
        }

        public long MCode { get; set; }
        public long MGoroh { get; set; }
        public string? MName { get; set; }
        public long? MAtbar { get; set; }
        public string? MTel1 { get; set; }
        public string? MTel2 { get; set; }
        public string? MMobil { get; set; }
        public string? MAddress { get; set; }
        public string? MMeli { get; set; }
        public bool? MLog { get; set; }
        public bool? MLogHsab { get; set; }
        public string MKol { get; set; } = null!;
        public string MMoein { get; set; } = null!;
        public string MTfzili { get; set; } = null!;
        public string MAcc { get; set; } = null!;
        public byte[]? MPic { get; set; }
        public string? MTxt { get; set; }
        public byte? MHmkar { get; set; }
        public byte? MLan { get; set; }
        public string? MNameL { get; set; }
        public byte? MOnvan { get; set; }
        public string? MDateList { get; set; }
        public string? MEconomy { get; set; }
        public string? MPost { get; set; }
        public string? MCity { get; set; }
        public string? MOstan { get; set; }
        public double? MPorsant { get; set; }
        public string? MEmail { get; set; }
        public long MCodeMantagh { get; set; }
        public string? MTel3 { get; set; }
        public string? MTel4 { get; set; }
        public string? MMobile2 { get; set; }
        public bool? MTelSms { get; set; }
        public string? MSabt { get; set; }
        public bool MModir { get; set; }
        [JsonIgnore]
        public virtual Onvan MAccNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual GorohM MGorohNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Factor1> Factor1FMoshtariNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Factor1> Factor1FPorsantNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Khadamat> Khadamats { get; set; }
        [JsonIgnore]
        public virtual ICollection<Payment1> Payment1s { get; set; }
    }
}
