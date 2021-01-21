using System;
using System.Collections.Generic;



namespace Plana.Models
{
    /*
     * example of ensure data: BZG1154, Wahrscheinlichkeitsrechnung und Statistik, 4
     */
    public class Module : ISoftDelete
    {
       
        public int ModuleId { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public int ECTS;

        public int LectPerWeek { get; set; }

        public double TotalHours { get; set; }

        public virtual ICollection<LecturerModule> Lecturers{ get; set; }

        
         public int? StudyBranchId { get; set; } //foreign key
                                                 
        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

    }
}
