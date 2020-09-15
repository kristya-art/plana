using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Plana.Models
{
    public class Lecturer : Employee, ISoftDelete
    {
        public string PhotoPath { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<LecturersModules> LecturersModules { get; set; }
        public ICollection<LecturersModuleRuns> LecturersModuleRuns { get; set; }
        public ICollection<LecturersSemesters> LecturersSemesters { get; set; }
        public ICollection<AdditionalAssignment> AdditionalAssignments { get; set; }
        

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
        public string SetToken() {
            
            Token = this.FirstName.Substring(0, 2).ToUpper() + this.LastName.Substring(0, 2).ToUpper() + BirthDate.Day;

          return Token;
        }
        // for many-to-many
        public void AddModuleRun(ModuleRun moduleRun)
        {
            LecturersModuleRuns lmr = new LecturersModuleRuns();
            lmr.Lecturer = this;
            lmr.ModuleRun = moduleRun;
            LecturersModuleRuns.Add(lmr);
        }

        // for many-to-many
        public void AddModule(Module module) {
            LecturersModules lm = new LecturersModules();
            lm.Module = module;
            lm.Lecturer = this;
            LecturersModules.Add(lm);

            
        }
        //for one-to-many
        public void AddAdditionalAssignment(AdditionalAssignment additionalAssignment) {
            additionalAssignment.Lecturer = this;
            AdditionalAssignments.Add(additionalAssignment);
        
        }


        // public HashSet<LecturersModules> Modules { get; set; }

       

        

        public override string DisplayData()
        {
            throw new NotImplementedException();
        }

      
    }
    
}
