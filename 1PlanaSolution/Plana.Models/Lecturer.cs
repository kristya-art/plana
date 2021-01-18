using System;
using System.Collections.Generic;

namespace Plana.Models
{
    public class Lecturer : Employee, ISoftDelete
    {
        public string PhotoPath { get; set; }

        public bool isSelected { get; set; }

        public virtual ICollection<LecturerModule> LecturersModules { get; set; }

        public virtual ICollection<LecturerModuleRun> LecturersModuleRuns { get; set; }

        
        public virtual ICollection<LecturerSemester> LecturersSemesters { get; set; }
        
        public virtual ICollection<AdditionalAssignment> AdditionalAssignments { get; set; }
       
        public virtual ICollection<LecturerModuleGroup> LecturerModuleGroup { get; set; }
        
        public virtual ICollection<LecturerLecturerGroup> LecturerLecturerGroup { get; set; }
        
        public virtual ICollection<PlanLecturer> PlanLecturers { get; set; }

        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime SetActiveDate()
        {
            return ActiveTill = new DateTime(2030, 12, 31);
        }

        public void Active()
        {
            if (ActiveTill > DateTime.Today)
            {
                _ = IsActive == true;
            }
            else { _ = IsActive == false; }
        }

        // get tocken from name and surname
        public string SetToken()
        {

            Token = this.FirstName.Substring(0, 2).ToUpper() + this.LastName.Substring(0, 2).ToUpper() + BirthDate.Day;

            return Token;
        }

        // for many-to-many
        public void AddModuleRun(ModuleRun moduleRun)
        {
            LecturerModuleRun lmr = new LecturerModuleRun();
            lmr.Lecturer = this;
            lmr.ModuleRun = moduleRun;
            LecturersModuleRuns.Add(lmr);
        }

        // for many-to-many
        public void AddModule(Module module)
        {
            LecturerModule lm = new LecturerModule();
            lm.Module = module;
            lm.Lecturer = this;
            LecturersModules.Add(lm);
        }

        public override string DisplayData()
        {
            throw new NotImplementedException();
        }
    }
}
