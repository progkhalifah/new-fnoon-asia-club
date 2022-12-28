using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblKarateCertificate
    {
        public int KrtId { get; set; }
        public string KrtFullNameAr { get; set; }
        public string KrtIdentification { get; set; }
        public string KrtBirthday { get; set; }
        public int? KrtFstPhone { get; set; }
        public int? KrtSedPhone { get; set; }
        public string KrtBranchAsia { get; set; }
        public byte[] KrtImagePlayer { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
