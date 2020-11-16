﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Plana.Models
{
    public class Plan : PlanaEntity, ISoftDelete
    {

        public bool IsFixed { get; set; }
        public bool IsModifyable { get; set; }
        public string Year { get; set; }
        public string ExpiredDate { get; set; }
        public string OfficialPublishDate { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        // public ICollection<Plan> MyPlan { get; set; }
        public ICollection<PlanLecturer> PlanLecturers { get; set; }
        [ForeignKey("AutumnSemesterId")]
        public virtual Semester AutumnSemester { get; set; }
        [ForeignKey("SpringSemesterId")]
        public virtual Semester SpringSemester { get; set; }

    }
}
