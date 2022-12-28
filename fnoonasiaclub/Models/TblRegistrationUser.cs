using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fnoonasiaclub.Models
{
    public class TblRegistrationUser : IdentityUser
    {

        [Required]
        [Display(Name = "FullName")]
        public string NameA { get; set; }

        [Display(Name = "Id_Player")]
        public int Id_player { get; set; }

        [Required]
        [Display(Name = "Game")]
        public string Game { get; set; }


        [Required]
        [Display(Name = "Duration Month")]
        public string DurationMonth { get; set; }


        [Required]
        [Display(Name = "BirthDay")]
        public string DateBirth { get; set; }


        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }


        [Required]
        [Display(Name = "Identification")]
        public string Identification { get; set; }


        [Required]
        [Display(Name = "Cell Phone")]
        public string Cellphone { get; set; }


        [Required]
        [Display(Name = "Cell Phone 2")]
        public string Cellphone2 { get; set; }


        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Required]
        [Display(Name = "Father's Job")]
        public string GuardianWork { get; set; }


        [Required]
        [Display(Name = "Branch")]
        public string Place { get; set; }


        
        [Display(Name = "Add Another Game")]
        public string AddAnotherGame { get; set; }


        
        [Display(Name = "Duration Month Another Game")]
        public string DurationAnotherGame { get; set; }


        [Display(Name = "Image Transfer")]
        public byte[] ImageTransfer { get; set; }

        
        public DateTime? Datetime { get; set; }


    }
}
