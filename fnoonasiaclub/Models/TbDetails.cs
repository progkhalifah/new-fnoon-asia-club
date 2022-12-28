using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbDetails
    {
        public int NumDetails { get; set; }
        public string TxtDetails { get; set; }
        public int? StatNo { get; set; }
        public int? IdPlay { get; set; }
        public int? IdBelt { get; set; }
        public string ToDay { get; set; }
        public int? IdSub { get; set; }
        public int? NumExreises { get; set; }
        public int? NumDay { get; set; }
        public bool? Arrest { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string UserName { get; set; }
        public int RestExercises { get; set; }
        public string NumClass { get; set; }
    }
}
