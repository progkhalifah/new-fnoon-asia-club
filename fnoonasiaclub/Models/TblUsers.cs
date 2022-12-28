using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblUsers
    {
        public int UNo { get; set; }
        public string UFname { get; set; }
        public string UName { get; set; }
        public string UPassword { get; set; }
        public string UTel { get; set; }
        public string UEmail { get; set; }
        public byte[] UImage { get; set; }
    }
}
