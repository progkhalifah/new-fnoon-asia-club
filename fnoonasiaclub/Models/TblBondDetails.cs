using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblBondDetails
    {
        public int Id { get; set; }
        public int? AccNo { get; set; }
        public decimal? Amount { get; set; }
        public string BNote { get; set; }
        public int? BCurr { get; set; }
        public int? BNo { get; set; }
        public decimal? CurrExch { get; set; }

        public virtual TblBondHdr BNoNavigation { get; set; }
    }
}
