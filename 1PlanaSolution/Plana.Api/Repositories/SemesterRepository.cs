using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly AppDbContext context;

        public SemesterRepository(AppDbContext context) {
            this.context = context;
        }
        
        public async Task<Semester> CreateSemester(Semester semester)
        {
           var result=await context.Semesters.AddAsync(semester);
            await context.SaveChangesAsync();
            return result.Entity;
        }

       

        public async Task<Semester> GetSemester(int? semesterId)
        {

            //return await context.Semesters

            //    //.Include(e => e.ModuleRuns)
            //    //.Include(e => e.LecturersSemesters)

            //   .FindAsync(semesterId);
            if (semesterId == null)
            {
                return NotFound();
            }
            var result = await context.Semesters
                 .Include(e => e.ModuleRuns)
                      .ThenInclude(mr => mr.LecturersMR)
                          .ThenInclude(l => l.Lecturer)
                 .Include(e => e.ModuleRuns)
                 .ThenInclude(mr => mr.Module)
                 .AsNoTracking()
               // .Include(e=>e.LecturersSemesters)
              //  .ThenInclude(l=>l.Lecturer)

                .Include(e=>e.AdditionalAssignments)
                .FirstOrDefaultAsync(e => e.SemesterId == semesterId);
            return result;
        }

        private Semester NotFound()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Semester>> GetSemesters()
        {
            //  return await context.Semesters.ToListAsync();
            return await context.Semesters
                   .Include(i => i.ModuleRuns)
                  
                   
                   
                  .Include( i=> i.LecturersSemesters)
                  .ThenInclude(m => m.Lecturer)
                  .Include(i => i.AdditionalAssignments)
                 
                  //.OrderBy(n => n.Date)
                  .ToListAsync();

        }



        public async Task<Semester> UpdateSemester(Semester semester)
        {
            var result = await GetSemester(semester.SemesterId);
            if (result != null)
            {
               // context.Entry(result.Code).State = EntityState.Modified;
                result.Code = semester.Code;
                result.Date = semester.Date;
                result.LecturersSemesters = semester.LecturersSemesters;
                foreach (var ls in semester.LecturersSemesters)
                {
                    context.Entry(ls).State = EntityState.Modified;
                }
                result.ModuleRuns = semester.ModuleRuns;
                



                await context.SaveChangesAsync();
                return result;

            }
            return null;
        }

        public async Task<bool> SoftDeleteSemester(int semesterId)
        {
            var result = await GetSemester(semesterId);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.Semesters.Update(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
        public Task<bool> DeleteSemester(int semesterId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Semester>> Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
