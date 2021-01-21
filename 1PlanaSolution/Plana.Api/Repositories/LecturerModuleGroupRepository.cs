using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerModuleGroupRepository : ILecturerModuleGroupRepository
    {

        private readonly AppDbContext context;


        public LecturerModuleGroupRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<LecturerModuleGroup> AddLecturerModuleGroup(LecturerModuleGroup lecturerModuleGroup)
        {
            var result = await context.LecturerModuleGroups.AddAsync(lecturerModuleGroup);


            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<LecturerModuleGroup> GetLecturerModuleGroup(int lecturerModuleGroupId)
        {
            return await context.LecturerModuleGroups.FindAsync(lecturerModuleGroupId);

        }

        public async Task<IEnumerable<LecturerModuleGroup>> GetLecturerModuleGroups()
        {
            return await context.LecturerModuleGroups
                .Include(i=>i.Lecturer)
                .Include(i=>i.ModuleGroup)
                .ToListAsync();
        }

        public async Task<LecturerModuleGroup?> UpdateLecturerModuleGroup(LecturerModuleGroup lecturerModuleGroup)
        {
            var result = await GetLecturerModuleGroup(lecturerModuleGroup.LecturerId);
            if (result != null)
            {
                result.Lecturer = lecturerModuleGroup.Lecturer;
                result.ModuleGroup = lecturerModuleGroup.ModuleGroup;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
