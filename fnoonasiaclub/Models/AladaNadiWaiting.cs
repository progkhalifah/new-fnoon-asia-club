using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class AladaNadiWaiting
    {
        public int Id { get; set; }
        public string NameA { get; set; }
        public string Password { get; set; }
        public string Game { get; set; }
        public string DurationMonth { get; set; }
        public string DateBirth { get; set; }
        public string Nationality { get; set; }
        public string Identification { get; set; }
        public string Cellphone { get; set; }
        public string Cellphone2 { get; set; }
        public string Address { get; set; }
        public string GuardianWork { get; set; }
        public string Place { get; set; }
        public string AddAnotherGame { get; set; }
        public string DurationAnotherGame { get; set; }
        public byte[] ImageTransfer { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
