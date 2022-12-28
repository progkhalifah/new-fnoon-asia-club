using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class ViewUserInformation
    {
        public int? OldId { get; set; }
        public string Identification { get; set; }
        public string Password { get; set; }
        public int StatNo { get; set; }
        public string NameA { get; set; }
        public string TxtDetails { get; set; }
        public string BranchNum { get; set; }
        public string NamePlay { get; set; }
        public string NameBelt { get; set; }
        public int? NumExreises { get; set; }
        public bool? Arrest { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public int RestExercises { get; set; }
        public string NumClass { get; set; }
        public int? Expr1 { get; set; }
        public string NameSub { get; set; }
        public string DateDay { get; set; }
        public string Expr2 { get; set; }
        public byte[] ImagePlayer { get; set; }
    }
}
