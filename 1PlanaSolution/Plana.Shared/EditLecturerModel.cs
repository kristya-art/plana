using System;
using System.ComponentModel.DataAnnotations;

namespace Plana.Shared
{
    public class EditLecturerModel
    {
        public int LecturerId { get; set; }
        [Required(ErrorMessage = "FirstName must be provided")]
        [MinLength(2)]

        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName must be provided")]
        [MinLength(2)]
        public string LastName { get; set; }
        
        public string Token { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }
        
        public string Password { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public double WorkingRate { get; set; }
        
        public bool IsActive { get; set; }
        
        public string PhotoPath { get; set; }
        
        public DateTime ActiveTill { get; set; }

        public string SetToken()
        {
            Token = FirstName.Substring(0, 1).ToUpper() + LastName.Substring(0, 1).ToUpper();
            return Token;
        }
    }
}
