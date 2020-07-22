using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Plana.Models
{
    /*
     * example of ensure data: BZG1154, Wahrscheinlichkeitsrechnung und Statistik, 4
     */
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int ECTS;
        public int LectPerWeek { get; set; }
        public double TotalHours { get; set; }
      
        public HashSet<LecturersModules> Lecturers { get; set; }


        //1-many
        public List<ModuleRun> ModuleRuns { get; set; }
    }
}
