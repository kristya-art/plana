using System.Collections.Generic;

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
            HStotal = 0.0;
            foreach (var mr in Plan.AutumnSemester.ModuleRuns)
            {
                foreach (var lmr in mr.LecturersMR)
                {
                    if (lmr.LecturerId == Lecturer.Id)
                    {
                        HStotal = HStotal + lmr.Hours;
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
        public double GetAA()
        {
            List<SemesterDto> SemesterList = new List<SemesterDto>();
            SemesterList.Add(Plan.AutumnSemester);
            SemesterList.Add(Plan.SpringSemester);

            AAtotal = 0.0;
            foreach(var aa in Lecturer.AdditionalAssignments)
            {
                foreach (var sem in SemesterList)
                {
                    if (aa.SemesterId == sem.SemesterId)
                    {
                        AAtotal += aa.AAHours;
                    }
                }

            }
            return AAtotal;
        }

        public double GetTotal()
        {
            return HStotal + FStotal + AAtotal;

        }
        /// <summary>
        /// this method to set total of lecturer working hours per year, this method can
        /// be extended if we know the hours for 100% working and the rate for concrete lecturer,
        /// it could be done like this hours(100%) * working rate. But in our case we make it easier cuz 
        /// we don't know how it shall to be calculated exactly
        /// </summary>
        /// <returns></returns>
        public double SetAnnualTarget()
        {
            AnnualTarget = Lecturer.WorkingHours;
            return AnnualTarget;
        }
    }
}
