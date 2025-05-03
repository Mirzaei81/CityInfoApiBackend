using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public partial class Onvan
    {
        public Onvan()
        {
        }

        [Key]
        public byte? OGoroh { get; set; }
    }
}
