namespace Plana.Shared
{
    public class PlanLecturerDto
    {
        public int LecturerId { get; set; }

        public int PlanId { get; set; }
        public virtual EditLecturerModel Lecturer { get; set; }

        public virtual PlanDto Plan { get; set; }

        public int AnnualTarget { get; set; }

        public int BalanceActual { get; set; }

        public int BalanceLastYear { get; set; }

        public int BalanceAccumulated { get; set; }
    }
}
