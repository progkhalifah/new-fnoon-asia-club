using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblCurrencies
    {
        public int CurrNo { get; set; }
        public string CurrName { get; set; }
        public string CurrEname { get; set; }
        public string CurrSymbol { get; set; }
        public decimal? CurrExch { get; set; }
        public string CurrPart { get; set; }
        public int? CurrType { get; set; }
    }
}
