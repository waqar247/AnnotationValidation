using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using validationEntries.Validation;

namespace validationEntries.Models
{
    public class User : ValidatableBase
    {
        string forename, surname,email;
        int i;
        const string NAMESREGEXPATTERN = @"\A\p{L}+([\p{Zs}\-][\p{L}]+)*\z";

        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(NAMESREGEXPATTERN, ErrorMessage = "This field contains invalid characters.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "This field requires a minimum of 2 characters and a maximum of 10.")]
        public string Forename
        {
            get { return forename; }
            set { SetProperty(ref forename, value); }
        }
        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress(ErrorMessage ="Enter Valid Email Address")]
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(NAMESREGEXPATTERN, ErrorMessage = "This field contains invalid characters.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "This field requires a minimum of 2 characters and a maximum of 15.")]

        public string Surname
        {
            get { return surname; }
            set { SetProperty(ref surname, value); }
        }
    }
}
