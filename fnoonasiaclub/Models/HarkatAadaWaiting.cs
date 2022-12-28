using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class HarkatAadaWaiting
    {
        public int Id { get; set; }
        public int? IidAladaNadi { get; set; }
        public string NamePlayer { get; set; }
        public string Game { get; set; }
        public string DurationMonths { get; set; }
        public string Feetype { get; set; }
        public string Place { get; set; }
        public byte[] ImageTransfer { get; set; }
        public DateTime? Date { get; set; }
    }
}
