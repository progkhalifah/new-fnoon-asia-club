using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class ShehdatEtehad
    {
        public int Id { get; set; }
        public int? Iid { get; set; }
        public int? NumShehada { get; set; }
        public string Alhezam { get; set; }
        public string DateM { get; set; }
        public int? NumMsave { get; set; }
        public string Masdrha { get; set; }
        public string NamePlay { get; set; }
        public string Notes { get; set; }
        public DateTime? DateDay { get; set; }
        public DateTime? TimeDay { get; set; }
        public string Place { get; set; }
    }
}
