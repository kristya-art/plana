using System;

namespace Plana.Models
{
    public class PlanLecturer : ISoftDelete
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }

        public int AnnualTarget { get; set; }
        public int BalanceActual { get; set; }
        public int BalanceLastYear { get; set; }
        public int BalanceAccumulated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}