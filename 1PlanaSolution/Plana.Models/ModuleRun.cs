using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Plana.Models
{
    
    public class ModuleRun
    {
       // [Key]
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
        public double ModuleRunRate { get; set; }
        //many-many
       // public HashSet<Lecturer> Lecturers {get;set;}
      public ICollection<LecturersModuleRuns> LecturersMR { get; set; }
       

        


        public int ModuleId { get; set; } // Foreign key many-to-one

        public int SemesterId { get; set; } //Foreign key many-to-one

        public void AddLecturer(Lecturer Lecturer) {
            this.AddLecturer(Lecturer);
            Lecturer.AddModuleRun(this);
        }


    }
}
