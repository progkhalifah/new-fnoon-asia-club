using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblJournalHdr
    {
        public TblJournalHdr()
        {
            TblJournalDetails = new HashSet<TblJournalDetails>();
        }

        public int JNo { get; set; }
        public DateTime JDate { get; set; }
        public string JNote { get; set; }
        public int JType { get; set; }
        public int? JPost { get; set; }
        public decimal TDebit { get; set; }
        public decimal TCredit { get; set; }
        public decimal TBalance { get; set; }
        public int? UAdd { get; set; }
        public DateTime? AddDate { get; set; }
        public int? UEdit { get; set; }
        public DateTime? EditDate { get; set; }
        public int? CurrNo { get; set; }
        public decimal? CurrExch { get; set; }
        public int? PNo { get; set; }

        public virtual ICollection<TblJournalDetails> TblJournalDetails { get; set; }
    }
}
