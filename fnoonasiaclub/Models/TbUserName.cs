using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbUserName
    {
        public string UserName { get; set; }
        public string Psw { get; set; }
        public string FullName { get; set; }
        public int? IdBranch { get; set; }
    }
}
