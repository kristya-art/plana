using System;
using System.Collections.Generic;

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
      
        //relationship

        //1-many
        public virtual ICollection<ModuleRun> ModuleRuns { get; set; }

        public virtual ICollection<AdditionalAssignment> AdditionalAssignments { get; set; }

        public virtual ICollection<LecturerSemester> LecturersSemesters { get; set; }

        /// <summary>
        /// this method takes last 2 letters from the semester code "HS or FS"
        /// </summary>
        /// <returns></returns>
        public string GetAbbreviation() {
            var last2= Code.Substring(Code.Length - 2);
            return last2;
        }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }



    }
}
