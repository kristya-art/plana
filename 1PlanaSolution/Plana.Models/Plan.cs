using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Plana.Models
{
    public class Plan : PlanaEntity, ISoftDelete
    {

        public bool IsFixed { get; set; }
        public bool IsModifyable { get; set; }
        public string Year { get; set; }
        public DateTime? ExpiredDate { get; set; }
        
        public DateTime? OfficialPublishDate { get; set; }
        public DateTime? PublishDateForProfessors { get; set; }
        // public ICollection<Plan> MyPlan { get; set; }
        public virtual ICollection<PlanLecturer> PlanLecturers { get; set; }
        /// <summary>
        /// below is the inverse property data annotation
        /// could be done also with 
        /// public int AutumnSemesterId {get;set;}
        /// public Semester AutumnSemester {get;set;}
        /// </summary>

        [ForeignKey("AutumnSemesterId")]
        public virtual Semester AutumnSemester { get; set; } = new Semester();
        [ForeignKey("SpringSemesterId")]
        public virtual Semester SpringSemester { get; set; } = new Semester();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
