using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Plana.Models
{
    
    public class ModuleRun
    {
        [Key]
        public int ModuleRunId { get; set; }
        //'a', 'b', 'p','q'
        public string Code;
        //many-1
        public Semester Semester { get; set; }
        //many-1
        public Module Module { get; set; }
        
        //Biel, Bern
        public string Place { get; set; }
        //1/3, 1/2, 1/4
        public double ModuleRunRate { get; set; }
        //many-many
        public HashSet<Lecturer> Lecturers {get;set;}
     }
}
