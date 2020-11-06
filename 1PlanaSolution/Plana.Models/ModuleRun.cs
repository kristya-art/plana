﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Plana.Models
{
    
    public class ModuleRun : ISoftDelete
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
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        //1/3, 1/2, 1/4
        //public double ModuleRunRate { get; set; } // maybe better to have it in lecturersmoduleruns
        //many-many
        // public HashSet<Lecturer> Lecturers {get;set;}
        public ICollection<LecturerModuleRun> LecturersMR { get; set; }
       
        public int ModuleId { get; set; } // Foreign key many-to-one

        public int SemesterId { get; set; } //Foreign key many-to-one
        
        public ModuleGroup ModuleGroup { get; set; }
       


    }
}
