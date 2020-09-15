using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class StudyBranchRepository : IStudyBranchRepository
    {
        private readonly AppDbContext context;

        public StudyBranchRepository(AppDbContext context) {
            this.context = context;
        }
        public async Task<StudyBranch> CreateStudyBranch(StudyBranch studyBranch)
        {
            var result = await context.StudyBranches.AddAsync(studyBranch);

            await context.SaveChangesAsync();
            return result.Entity;
        }

       

        public async Task<StudyBranch> GetStudyBranch(int studyBranchId)
        {
            return await context.StudyBranches.FirstOrDefaultAsync(e => e.StudyBranchId == studyBranchId);

        }

        public async Task<IEnumerable<StudyBranch>> GetStudyBranches()
        {
            return await context.StudyBranches.ToListAsync();
        }

      
       

        public async Task<StudyBranch> UpdateStudyBranch(StudyBranch studyBranch)
        {
            var result = await context.StudyBranches
                .FirstOrDefaultAsync(e => e.StudyBranchId == studyBranch.StudyBranchId);
            if (result != null)
            {
                result.Title = studyBranch.Title;
                result.Code = studyBranch.Code;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<bool> SoftDeleteStudyBranch(int studyBranchId)
        {
            var result = await context.StudyBranches
                .FirstOrDefaultAsync(e => e.StudyBranchId == studyBranchId);
            if (result != null) {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.StudyBranches.Update(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
        public async Task<bool> DeleteStudyBranch(int studyBranchId)
        {
            var result = await context.StudyBranches
                .FirstOrDefaultAsync(e => e.StudyBranchId == studyBranchId);
            if (result != null) {
                context.StudyBranches.Remove(result);
                context.SaveChanges();
                return true;

            }
            return false;
        }

        public Task<IEnumerable<StudyBranch>> Search(string name, string code)
        {
            throw new NotImplementedException();
        }



    }
}
