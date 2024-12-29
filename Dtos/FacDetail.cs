namespace CityInfoApi.Dtos
{
    public class FactorDetail
    {
        public int K_Code { get; set; }
        public string K_Name { get; set; }

        public int? FK_koli { get; set; }
        public double? K_zarib { get; set; }
        public string K_Vahed { get; set; }
        public double? FK_Num { get; set; }
        public double? FK_Mab { get; set; }
        public double? FK_Mab_koli { get; set; }
        public FactorDetail(int Code ,string Name,int? koli,double? zarib,string Vahed,double? FNum,double? FMab,double? Fkoli)
        {
            K_Code = Code;
            K_Name = Name;
            FK_koli = koli;
            K_zarib=zarib;
            K_Vahed = Vahed;
            FK_Num = FNum;
            FK_Mab = FMab;
            FK_Mab_koli = Fkoli;
        }
    }
}
