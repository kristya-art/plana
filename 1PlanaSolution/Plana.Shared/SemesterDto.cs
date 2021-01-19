using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Plana.Shared

{
    public class SemesterDto 
    {
        public int SemesterId { get; set; }
        [Required(ErrorMessage = "The Title of Semester must be provided!")]
        [MinLength(7)]
        public string Code { get; set; }
        public DateTime Date { get; set; }

        //relationship

        //1-many
        public virtual ICollection<ModuleRunDto> ModuleRuns { get; set; }
        public virtual ICollection<AdditionalAssignmentDto> AdditionalAssignments { get; set; }

        public virtual ICollection<LecturerSemesterDto> LecturersSemesters { get; set; }

        /// <summary>
        /// this method takes last 2 letters from the semester code "HS or FS"
        /// </summary>
        /// <returns></returns>
        public string GetAbbreviation()
        {
            var last2 = Code.Substring(Code.Length - 2);
            return last2;
        }
    }
}
