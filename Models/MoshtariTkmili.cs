using System;
using System.Collections.Generic;

namespace CityInfoApi.Models
{
    public partial class MoshtariTkmili
    {
        public int MCodeM { get; set; }
        public string? MFather { get; set; }
        public string? MTavalod { get; set; }
        public string? MSadere { get; set; }
        public string? MShnasnameh { get; set; }
        public string? MAddressMnzl { get; set; }
        public string? MAddressKar { get; set; }
        public string? MVsighe { get; set; }
        public string? MDateFirst { get; set; }
        public string? MDateEnd { get; set; }
        public string? MZmn1 { get; set; }
        public string? MZmn1CodeMli { get; set; }
        public string? MZmn1Tel { get; set; }
        public string? MZmn1Address { get; set; }
        public string? MZmn1Vsighe { get; set; }
        public string? MZmn2 { get; set; }
        public string? MZmn2CodeMli { get; set; }
        public string? MZmn2Tel { get; set; }
        public string? MZmn2Address { get; set; }
        public string? MZmn2Vsighe { get; set; }
        public string? MZmn3 { get; set; }
        public string? MZmn3CodeMli { get; set; }
        public string? MZmn3Tel { get; set; }
        public string? MZmn3Address { get; set; }
        public string? MZmn3Vsighe { get; set; }

        public virtual Moshtari MCodeMNavigation { get; set; } = null!;
    }
}
