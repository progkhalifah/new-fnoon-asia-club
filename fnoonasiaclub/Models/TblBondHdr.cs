using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblBondHdr
    {
        public TblBondHdr()
        {
            TblBondDetails = new HashSet<TblBondDetails>();
        }

        public int BNo { get; set; }
        public DateTime? BDate { get; set; }
        public string BNote { get; set; }
        public int? BType { get; set; }
        public int? BPost { get; set; }
        public decimal? AccBalance { get; set; }
        public int? AccCashNo { get; set; }
        public int? AccBankNo { get; set; }
        public int? UAdd { get; set; }
        public DateTime? AddDate { get; set; }
        public int? UEdit { get; set; }
        public DateTime? EditDate { get; set; }
        public int? JNo { get; set; }

        public virtual ICollection<TblBondDetails> TblBondDetails { get; set; }
    }
}
