using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Plana.Models
{
    public class Lecturer : Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LecturerId { get; set; }
        public string PhotoPath { get; set; }

        
        
        
        public DateTime SetActiveDate() { 
            return ActiveTill = new DateTime(2030, 12, 31);

        }
        public void Active() {
            if (ActiveTill > DateTime.Today) {
                _ = IsActive == true;
            }
            else { _ = IsActive == false; }
        }

        // get tocken from name and surname
        public string SetTocken() {
           Token= this.FirstName.Substring(0, 1).ToUpper() + this.LastName.Substring(0, 1).ToUpper();
            return Token;
        }
        
      // public HashSet<LecturersModules> Modules { get; set; }

        public ICollection<LecturersModules> Modules { get; set; }
        public ICollection<LecturersModuleRuns> LecturersModuleRuns { get; set; }
        public ICollection<LecturersSemesters> LecturersSemesters { get; set; }

        

        public override string DisplayData()
        {
            throw new NotImplementedException();
        }
    }
    
}
