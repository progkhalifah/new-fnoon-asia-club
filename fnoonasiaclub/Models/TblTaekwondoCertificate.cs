using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblTaekwondoCertificate
    {
        public int TwkId { get; set; }
        public string TwkFullNameAr { get; set; }
        public string TwkFullNameEn { get; set; }
        public string TwkIdentification { get; set; }
        public string TwkBirthday { get; set; }
        public int? TwkFstPhone { get; set; }
        public int? TwkSedPhone { get; set; }
        public string TwkBranchAsia { get; set; }
        public byte[] TwkImagePlayer { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
