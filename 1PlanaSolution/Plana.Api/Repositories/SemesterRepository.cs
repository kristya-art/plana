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

       

        public async Task<Semester> GetSemester(int semesterId)
        {

            return await context.Semesters.FindAsync(semesterId);
        }

        public async Task<IEnumerable<Semester>> GetSemesters()
        {
            return await context.Semesters.ToListAsync();
        }

       

        public async Task<Semester> UpdateSemester(Semester semester)
        {
            var result = await GetSemester(semester.SemesterId);
            if (result != null)
            {
                result.Code = result.Code;
                result.Date = result.Date;
               

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
    }
}
