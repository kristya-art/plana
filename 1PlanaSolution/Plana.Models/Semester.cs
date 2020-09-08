using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


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
        //1-many
        public HashSet<ModuleRun> ModuleRuns = new HashSet<ModuleRun>();

        public ICollection<LecturersSemesters> LecturersSemesters { get; set; }
        public bool IsDeleted { get; set ; }
        public DateTime? DeletedAt { get; set; }
    }
}
