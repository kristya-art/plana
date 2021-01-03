using System;

namespace Plana.Models
{
    public class PlanLecturer : ISoftDelete
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public double HStotal { get; set; } = 0.0;
        public double FStotal { get; set; } = 0.0;

        public double AAtotal { get; set; }

        public double YearTotal { get; set; } 

        public double AnnualTarget { get; set; }
        public double BalanceActual { get; set; }
        public double BalanceLastYear { get; set; }
        public double BalanceAccumulated { get; set; }

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
        public double GetTotal() {
            return HStotal + FStotal + AAtotal;

        }
            
    }
}