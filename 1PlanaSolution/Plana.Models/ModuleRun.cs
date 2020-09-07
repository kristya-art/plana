using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Plana.Models
{
    
    public class ModuleRun
    {
       
      
        public int ModuleRunId { get; set; }
        //'a', 'b', 'p','q'
        public string Code { get; set; }
        //many-1
        public Semester Semester { get; set; }
        //many-1
        public Module Module { get; set; }
        
        //Biel, Bern
        public string Place { get; set; }
        //1/3, 1/2, 1/4
        public double ModuleRunRate { get; set; } // maybe better to have it in lecturersmoduleruns
        //many-many
       // public HashSet<Lecturer> Lecturers {get;set;}
      public ICollection<LecturersModuleRuns> LecturersMR { get; set; }
       

        


        public int ModuleId { get; set; } // Foreign key many-to-one

        public int SemesterId { get; set; } //Foreign key many-to-one


        //public ModuleRun(string code, Module module, Semester semester, ICollection<LecturersModuleRuns> lmr)
        //{
        //    Code = code;
        //    Module = module;
        //    Semester = semester;
        //    LecturersMR = lmr;
            
        //}

        public void AddLecturer(Lecturer Lecturer) {
            this.AddLecturer(Lecturer);
            Lecturer.AddModuleRun(this);
        }

        public void AddModule(Module Module) {
            this.AddModule(Module);
            
        }
 }
}
