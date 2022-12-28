using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblAccounts
    {
        public int AccNo { get; set; }
        public int? AccParentNo { get; set; }
        public string AccAname { get; set; }
        public int? AccType { get; set; }
        public int? AccReport { get; set; }
        public int? AccLevel { get; set; }
        public decimal? AccDebit { get; set; }
        public decimal? AccCredit { get; set; }
        public decimal? AccBalance { get; set; }
    }
}
