using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Plana.Models
{
    /*
     * example of ensure data: BZG1154, Wahrscheinlichkeitsrechnung und Statistik, 4
     */
    public class Module : ISoftDelete
    {
        //[Key]
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int ECTS;
        public int LectPerWeek { get; set; }
        public double TotalHours { get; set; }
        public virtual ICollection<LecturerModule> Lecturers{ get; set; }

        //1-many
      //  public virtual ICollection<ModuleRun> ModuleRuns { get; set; } //collection navigation property
         // many-to-one
         public int? StudyBranchId { get; set; } //foreign key
                                                 // public StudyBranch StudyBranch { get; set; } //reference navigation property
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
