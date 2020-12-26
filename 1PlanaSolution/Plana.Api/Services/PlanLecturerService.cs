using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class PlanLecturerService : IPlanLecturerService
    {

        private readonly AppDbContext context;


        public PlanLecturerService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<PlanLecturer> AddPlanLecturer(PlanLecturer planLecturer)
        {
            var result = await context.PlanLecturers.AddAsync(planLecturer);


            await context.SaveChangesAsync();
            return result.Entity;
        }
        /** completely delete*/
        public async Task<Boolean> DeletePlanLecturer(int id, int id2)
        {
            var result = await GetPlanLecturer(id,id2);
            if (result != null)
            {
                context.PlanLecturers.Remove(result);
                await context.SaveChangesAsync();
                
                return true; 
            }
            
            return false;
        }

        public async Task<PlanLecturer> GetPlanLecturer(int id, int id2)
        {
            return await context.PlanLecturers.FindAsync(id,id2);
        }

        public async Task<IEnumerable<PlanLecturer>> GetPlanLecturers()
        {
            return await context.PlanLecturers.ToListAsync();
        }

        public Task<IEnumerable<PlanLecturer>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Boolean> SoftDeletePlanLecturer(int id, int id2)
        {
            var result = await GetPlanLecturer(id, id2);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.PlanLecturers.Update(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<PlanLecturer> UpdatePlanLecturer(PlanLecturer planLecturer)
        {
            var result = await context.PlanLecturers.FindAsync(planLecturer.LecturerId, planLecturer.PlanId);
            if (result != null)
            {
                result.LecturerId = planLecturer.LecturerId;
                result.PlanId = planLecturer.PlanId;
                result.AnnualTarget = planLecturer.AnnualTarget;
                result.BalanceAccumulated = planLecturer.BalanceAccumulated;
                result.BalanceActual = planLecturer.BalanceActual;
                result.BalanceLastYear = planLecturer.BalanceLastYear;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }
        /** dosn't work*/
        public async Task<IEnumerable<ModuleRun>> GetLecturerModuleRuns(int planId,int lectId)
        {

            //planLecturer.LecturerId = lecturer.Id;
            //planLecturer.PlanId = plan.Id;
          
            ICollection<ModuleRun> moduleRuns = new List<ModuleRun>();
            var result = await GetPlanLecturer(planId,lectId);
            ICollection<Semester> semesters = new List<Semester>();

            if (result != null)
            {
                semesters.Add(result.Plan.AutumnSemester);
                semesters.Add(result.Plan.SpringSemester);
                foreach (var sem in semesters) 
                { 
                    foreach (var mr in sem.ModuleRuns)
                    {
                        
                            foreach (var mrl in mr.LecturersMR)
                            {
                                if (mrl.LecturerId == lectId)
                                {
                                    moduleRuns.Add(mr);
                                }
                            }
                        }

                    }
                return moduleRuns;

            }
            return moduleRuns;
        }
    }
}
