using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class NoteBook
    {
        public string Date { get; set; } = null!;
        public string? Note { get; set; }
    }
}
