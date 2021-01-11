using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Plana.Shared
{
    public class PlanDto
    {
        public int Id { get; set; }
        public bool IsFixed { get; set; }

        public bool IsModifyable { get; set; }
        [Required(ErrorMessage="The Year must be provided")]
        [MinLength(9)]
        public string Year { get; set; }
         
        public string LastYear { get; set; } 
        public DateTime? ExpiredDate { get; set; }

        public DateTime? OfficialPublishDate { get; set; }

        public DateTime? PublishDateForProfessors { get; set; }

        public virtual ICollection<PlanLecturerDto> PlanLecturers { get; set; }
        
        [ForeignKey("AutumnSemesterId")]
        public virtual SemesterDto AutumnSemester { get; set; } = new SemesterDto();

        [ForeignKey("SpringSemesterId")]
        public virtual SemesterDto SpringSemester { get; set; } = new SemesterDto();

        public string FindLastYearPlan() {
            var LastNumbers = Year.Substring(Year.Length - 2); // example 2020-2019  ==> 19 as string
            int LastNumbersInt = Int32.Parse(LastNumbers); //=> 19 as int 
            int LastYearLast2Numbers = LastNumbersInt - 1; // => 19-1 => 18 as int
            LastYear = LastYearLast2Numbers.ToString(); // => 18 as string
            return LastYear;
        
        }
    }
}
