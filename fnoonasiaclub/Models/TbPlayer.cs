using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbPlayer
    {
        public TbPlayer()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int StatNo { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public string NationalityNo { get; set; }
        public string Identification { get; set; }
        public string DateDay { get; set; }
        public string Cellphone { get; set; }
        public string Cellphone2 { get; set; }
        public string Address { get; set; }
        public string GuardianworkNo { get; set; }
        public string HealthStatus { get; set; }
        public int? BranchNo { get; set; }
        public string PlayerEmail { get; set; }
        public string Password { get; set; }
        public string Higry { get; set; }
        public string NameplayNo { get; set; }
        public int? DurationMonth { get; set; }
        public byte[] ImagePlayer { get; set; }
        public int? OldId { get; set; }

        public virtual TbBranch BranchNoNavigation { get; set; }
        public virtual ICollection<TblOrder> TblOrder { get; set; }
    }
}
