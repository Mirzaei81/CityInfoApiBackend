using CityInfoApi.Models;

namespace CityInfoApi.Dtos
{
    public class KalaDto:Kala
    {
        public int mojodi;
        public KalaDto(float mojodi)
        {
            this.mojodi = (int)mojodi;
        }
    }
}
