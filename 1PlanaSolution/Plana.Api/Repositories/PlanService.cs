//using Plana.Api.Models;
//using Plana.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Plana.Api.Repositories
//{
//    public class PlanService : IPlanService
//    {
//       readonly IAdditionalAssignmentRepository aaRep;
//        readonly IModuleRunRepository mrRep;
//        readonly ISemesterRepository semRep;
//        readonly ILecturerRepository lectRep;

//        public PlanService(ISemesterRepository semRep, ILecturerRepository lectRep, IModuleRunRepository mrRep, IAdditionalAssignmentRepository aaRep) {
//            this.semRep = semRep;
//            this.lectRep = lectRep;
//            this.aaRep = aaRep;
//            this.mrRep = mrRep;

//        }

//        public async Task MakePlan( Lecturer l, ModuleRun mr, AdditionalAssignment aa)
//        {
//            LecturersModuleRuns lm = new LecturersModuleRuns();
//            lm.ModuleRun = mr;
//            lm.Lecturer = l;


//            l.LecturersModuleRuns.Add(lm);
//           await  lectRep.UpdateLecturer(l);
//           await mrRep.UpdateModuleRun(mr);

//            l.AddAdditionalAssignment(aa);
            


//        }
//    }
//}
