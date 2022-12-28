using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbSubscition
    {
        public int IdSub { get; set; }
        public string NameSub { get; set; }
        public int? NumExreises { get; set; }
        public int? NumDay { get; set; }
    }
}
