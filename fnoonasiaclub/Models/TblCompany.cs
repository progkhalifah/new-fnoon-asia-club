using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblCompany
    {
        public int CNo { get; set; }
        public string CAname { get; set; }
        public string CEname { get; set; }
        public string CApos { get; set; }
        public string CEpos { get; set; }
        public string CTel { get; set; }
        public string CFax { get; set; }
        public string CEmail { get; set; }
        public string CWebsite { get; set; }
        public byte[] CLogo { get; set; }
    }
}
