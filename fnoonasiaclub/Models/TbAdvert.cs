using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbAdvert
    {
        public int Id { get; set; }
        public DateTime? Dm { get; set; }
        public string TimeD { get; set; }
        public string Dh { get; set; }
        public string Dhh { get; set; }
        public DateTime? Dmm { get; set; }
        public string FormHezam { get; set; }
        public string ToHezam { get; set; }
        public string NameMostow { get; set; }
        public string NamePlay { get; set; }
        public int? Amount { get; set; }
    }
}
