using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerGroupRepository : ILecturerGroupRepository
    {
        private readonly AppDbContext context;
        public async Task<bool> DeleteLecturerGroup(int lecturerGroupId)
        {
            var result = await GetLectureGroup(lecturerGroupId);
            if (result != null)
            {
                context.LecturerGroups.Remove(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<LecturerGroup> GetLectureGroup(int lecturerGroupId)
        {
            return await context.LecturerGroups.FindAsync(lecturerGroupId);
        }

        public async Task<IEnumerable<LecturerGroup>> GetLecturerGroups()
        {
            return await context.LecturerGroups
                .Include(i => i.LecturerLecturerGroup)
                .ThenInclude(l => l.Lecturer)
                .ToListAsync();
        }

        public async Task<LecturerGroup> AddLecturerGroup(LecturerGroup lecturerGroup)
        {
            var result = await context.LecturerGroups.AddAsync(lecturerGroup);

            await context.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<bool> SoftDeleteLecturerGroup(int lecturerGroupId)
        {
            var result = await GetLectureGroup(lecturerGroupId);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.LecturerGroups.Update(result);
                await context.SaveChangesAsync();

                return true;
            
            }
            return false;
        }

        public async Task<LecturerGroup> UpdateLecturerGroup(LecturerGroup lecturerGroup)
        {
            var result = await GetLectureGroup(lecturerGroup.LecturerGroupId);
            if (result != null)
            {
                result.Title = lecturerGroup.Title;
                result.LecturerLecturerGroup = lecturerGroup.LecturerLecturerGroup;
                result.LecturerSubGroups = lecturerGroup.LecturerSubGroups;
                result.LecturerGroupModuleGroup = lecturerGroup.LecturerGroupModuleGroup;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public Task<IEnumerable<LecturerGroup>> Search(string name)
        {
            throw new NotImplementedException();
        }

    }
}
