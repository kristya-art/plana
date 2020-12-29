using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plana.Shared
{
    public class LecturerDto 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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
        public Role Role { get; set; }

        public DateTime BirthDate { get; set; }

        public double WorkingRate { get; set; }

        public bool IsActive { get; set; }

        public string PhotoPath { get; set; }

        public DateTime ActiveTill { get; set; }
        public GenderDto Gender { get; set; }

        public virtual ICollection<LecturerModuleDto> LecturersModules { get; set; }

        public virtual ICollection<LecturerModuleRunDto> LecturersModuleRuns { get; set; }


        public virtual ICollection<LecturerSemesterDto> LecturersSemesters { get; set; }

        public virtual ICollection<AdditionalAssignmentDto> AdditionalAssignments { get; set; }

        public virtual ICollection<LecturerModuleGroupDto> LecturerModuleGroup { get; set; }

        public virtual ICollection<LecturerLecturerGroupDto> LecturerLecturerGroup { get; set; }

        public virtual ICollection<PlanLecturerDto> PlanLecturers { get; set; }

        public string SetToken()
        {
            Token = FirstName.Substring(0, 1).ToUpper() + LastName.Substring(0, 1).ToUpper();
            return Token;
        }
        //public override string DisplayData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
