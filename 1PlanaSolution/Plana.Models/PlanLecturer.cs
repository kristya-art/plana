namespace Plana.Models
{
    public class PlanLecturer
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public int AnnualTarget { get; set; }
        public int BalanceActual { get; set; }
        public int BalanceLastYear { get; set; }
        public int BalanceAccumulated { get; set; }
    }
}