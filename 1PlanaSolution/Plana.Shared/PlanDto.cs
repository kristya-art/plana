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
        //[MinLength(9)]
        public string Year { get; set; } 
        
        public string LastYear { get; set; } 

        public DateTime? ExpiredDate { get; set; }

        public DateTime? OfficialPublishDate { get; set; }

        public DateTime? PublishDateForProfessors { get; set; }

        public virtual ICollection<PlanLecturerDto> PlanLecturers { get; set; }

        // [Required(ErrorMessage = "Must be provided")]
        public virtual SemesterDto AutumnSemester { get; set; } = new SemesterDto();



        //[Required(ErrorMessage = "Must be provided")]
        public virtual SemesterDto SpringSemester { get; set; } = new SemesterDto();

       

           public string FindLastYearPlan() {
            var secondY = (Int32.Parse(Year.Substring(7,2)) -1).ToString();
            var firstY = (Int32.Parse(Year.Substring(2,2)) -1).ToString();
            LastYear = Year.Remove(2,2).Insert(2,firstY);
            LastYear = LastYear.Remove(7,2).Insert(7,secondY);
            return LastYear;

        }
       
    }
   
}
