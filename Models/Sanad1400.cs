using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models_new
{
    public class Sanad1400
    {
        [Key]
        public long id { get; set; }
        public long s_user { get; set; }
        public long s_date { get; set; }
    }
}
