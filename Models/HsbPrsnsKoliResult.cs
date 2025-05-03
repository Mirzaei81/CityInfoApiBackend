using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models_new
{
    public class HsbPrsnsKoli
    {
        public short? Brws { get; set; }
        public char KindFactor { get; set; }
        public string? Date { get; set; }
        [Key]
        public long No { get; set; }
        public string? kind { get; set; }
        public string? Sharh { get; set; }

        public double Bes { get; set; }
        public double Bed { get; set; }

        public long? F_Factor { get; set; }

        public long F { get; set; }

        public long Mande { get; set; }
    }




}
