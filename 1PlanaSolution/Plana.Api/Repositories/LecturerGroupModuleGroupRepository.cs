using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerGroupModuleGroupRepository : ILecturerGroupModuleGroupRepository
    {
        private readonly AppDbContext context;


        public LecturerGroupModuleGroupRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<LecturerGroupModuleGroup> AddLecturerGroupModuleGroup(LecturerGroupModuleGroup lecturerGroupModuleGroup)
        {
            var result = await context.LecturerGroupModuleGroups.AddAsync(lecturerGroupModuleGroup);


            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<LecturerGroupModuleGroup> GetLecturerGroupModuleGroup(int lecturerGroupModuleGroupId)
        {
            return await context.LecturerGroupModuleGroups.FindAsync(lecturerGroupModuleGroupId);
        }

        public async Task<IEnumerable<LecturerGroupModuleGroup>> GetLecturerGroupModuleGroups()
        {
            return await context.LecturerGroupModuleGroups
                .Include(i=>i.LecturerGroup)
                .ThenInclude(l=>l.LecturerLecturerGroup).ThenInclude(le=>le.Lecturer)
                .Include(i => i.ModuleGroup).ThenInclude(m=>m.ModuleRuns)
                .ToListAsync();
        }

        public async Task<LecturerGroupModuleGroup> UpdateLecturerGroupModuleGroup(LecturerGroupModuleGroup lecturerGroupModuleGroup)
        {
            var result = await GetLecturerGroupModuleGroup(lecturerGroupModuleGroup.LecturerGroupId);
            if (result != null)
            {
                result.LecturerGroup = lecturerGroupModuleGroup.LecturerGroup;
                result.ModuleGroup = result.ModuleGroup;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
