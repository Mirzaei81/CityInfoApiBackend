using System.Text.Json.Serialization;
namespace CityInfoApi.Dtos
{
    public partial class FactorDetail
    {
        public FactorDetail() { }
        public FactorDetail(int kCode, string kName, int fkNumkoli, double kZarib, string kVahed, double fkNum, double fkMab, double fkMabKoli)
        {
            KCode = kCode;
            KName = kName;
            FkNumkoli = fkNumkoli ;
            KZarib = kZarib;
            KVahed = kVahed;
            FkNum = fkNum;
            FkMab = fkMab;
            FkMabKoli = fkMabKoli;
        }

        [JsonPropertyName("K_Code")]
        public int KCode { get; set; }

        [JsonPropertyName("K_Name")]
        public string KName { get; set; }

        [JsonPropertyName("FK_Numkoli")]
        public long FkNumkoli { get; set; }

        [JsonPropertyName("K_zarib")]
        public double? KZarib { get; set; }

        [JsonPropertyName("K_Vahed")]
        public string KVahed { get; set; }

        [JsonPropertyName("FK_Num")]
        public double? FkNum { get; set; }

        [JsonPropertyName("FK_Mab")]
        public double? FkMab { get; set; }

        [JsonPropertyName("FK_Mab_koli")]
        public double? FkMabKoli { get; set; }
    };
}
