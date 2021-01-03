namespace Plana.Shared
{
    public class PlanLecturerDto
    {
        public int LecturerId { get; set; }

        public int PlanId { get; set; }
        public virtual LecturerDto Lecturer { get; set; }

        public virtual PlanDto Plan { get; set; }

       
        /// <summary>
        /// extra variables
        /// </summary>
        public int DesiredHours { get; set; }

        public double HStotal { get; set; }
        public double FStotal { get; set; }

        public double AAtotal { get; set; } = 0.0;

        public double YearTotal { get; set; } = 0.0;

        public double AnnualTarget { get; set; } = 0.0;
        public double BalanceActual { get; set; } = 0.0;
        public double BalanceLastYear { get; set; } = 0.0;
        public double BalanceAccumulated { get; set; } = 0.0;

        public double GetHStotal()
        {
            foreach (var mr in Plan.AutumnSemester.ModuleRuns)
            {
                foreach (var lmr in mr.LecturersMR)
                {
                    if (lmr.LecturerId == Lecturer.Id)
                    {
                        HStotal += lmr.Hours;
                    }

                }

            }
            return HStotal;

        }
        public double GetFStotal()
        {
            FStotal = 0.0;
            foreach (var mr in Plan.SpringSemester.ModuleRuns)
            {
                foreach (var lmr in mr.LecturersMR)
                {
                    if (lmr.LecturerId == Lecturer.Id)
                    {
                        FStotal += lmr.Hours;
                    }

                }

            }

            return FStotal;
        }
        //public double GetAA()
        //{
        //    AAtotal = 0.0;

        //}

        public double GetTotal()
        {
            return HStotal + FStotal + AAtotal;

        }
    }
}
