﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plana.Models
{
    /*
     *  example of ensureTermData: 2021-2022 - HS, 2015, 08 ;     2020-2021 - FS, 2016, 02
     */
    public class Semester : ISoftDelete
    {
        [Key]
        public int SemesterId { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        
        //relationship

        //1-many
        public ICollection<ModuleRun> ModuleRuns { get; set; }
        public ICollection<AdditionalAssignment> AdditionalAssignments { get; set; }

        public ICollection<LecturerSemester> LecturersSemesters { get; set; }
       
      
       
        //public string getYear(Semester semester) {
        //    return Plan.Year;
        
        //}
    }
}
