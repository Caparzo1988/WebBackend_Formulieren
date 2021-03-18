using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class EstaApplyViewModel
    {
        [Display(Name = "AankomstDatum :")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Emailadres :")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Mobiel Tel Nummer :")]
        [DataType(DataType.PhoneNumber)]
        public string TelNummer { get; set; }
       
        [Display(Name = "Postcode :")]
        public int Postcode { get; set; }

        [Display(Name = "Straat + Huisnummer :")]
        public string Adres { get; set; }

        [Display(Name = "Woonplaats")]
        public string Woonplaat { get; set; }

        [Display(Name = "Provincie :")]
        public string Provincie { get; set; }
    }
}
