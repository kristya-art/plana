using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Plana.Shared
{
    public class PlanDto
    {
        public int Id { get; set; }
        public bool IsFixed { get; set; }

        public bool IsModifyable { get; set; }

        public string Year { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? OfficialPublishDate { get; set; }

        public DateTime? PublishDateForProfessors { get; set; }

        public virtual ICollection<PlanLecturerDto> PlanLecturers { get; set; }
        
        [ForeignKey("AutumnSemesterId")]
        public virtual SemesterDto AutumnSemester { get; set; } = new SemesterDto();

        [ForeignKey("SpringSemesterId")]
        public virtual SemesterDto SpringSemester { get; set; } = new SemesterDto();
    }
}
