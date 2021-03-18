using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email mag niet leeg zijn!")]
        public string UserName { get; set; }

        [Display(Name = "Voornaam:")]
        [Required(ErrorMessage = "Voornaam mag niet leeg zijn!")]
        public string Firstname { get; set; }

        [Display(Name = "Naam:")]
        [Required(ErrorMessage = "Naam mag niet leeg zijn!")]
        public string Lastname { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Wachtwoord mag niet leeg zijn!")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Wachtwoord moet minimum 8 tekens bevatten")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Herhaal wachtwoord mag niet leeg zijn!")]
        [Compare(nameof(Password), ErrorMessage = "Paswoorden moeten gelijk zijn!")]
        public string RepeatPassword { get; set; }
    }
}
