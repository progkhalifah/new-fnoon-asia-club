using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblJournalDetails
    {
        public int Id { get; set; }
        public int? AccNo { get; set; }
        public decimal? AccDebit { get; set; }
        public decimal? AccCredit { get; set; }
        public string AccNote { get; set; }
        public int? JNo { get; set; }

        public virtual TblJournalHdr JNoNavigation { get; set; }
    }
}
