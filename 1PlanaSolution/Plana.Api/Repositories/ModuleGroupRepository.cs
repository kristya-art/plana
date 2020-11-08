using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class ModuleGroupRepository : IModuleGroupRepository
    {

        private readonly AppDbContext context;
        public async Task<ModuleGroup> AddModuleGroup(ModuleGroup moduleGroup)
        {
            var result = await context.ModuleGroups.AddAsync(moduleGroup);

            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> DeleteModuleGroup(int moduleGroupId)
        {
            var result = await GetModuleGroup(moduleGroupId);
            if (result != null)
            {
                context.ModuleGroups.Remove(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<ModuleGroup> GetModuleGroup(int moduleGroupId)
        {
            return await context.ModuleGroups.FindAsync(moduleGroupId);
        }

        public async Task<IEnumerable<ModuleGroup>> GetModuleGroups()
        {
            return await context.ModuleGroups
                .Include(i => i.ModuleRuns)
                .Include(i=>i.LecturerModuleGroup)
                .ThenInclude(l=>l.Lecturer)
                .Include(i=>i.LecturerGroupModuleGroup)
                .ThenInclude(l=>l.LecturerGroup)
                .ToListAsync();
        }

        public Task<IEnumerable<ModuleGroup>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SoftDeleteModuleGroup(int moduleId)
        {
            var result = await GetModuleGroup(moduleId);
            if (result != null)
            {
                result.IsDeleted =true;
                result.DeletedAt = DateTime.Now;

                context.ModuleGroups.Update(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<ModuleGroup> UpdateModuleGroup(ModuleGroup moduleGroup)
        {
            var result = await GetModuleGroup(moduleGroup.ModuleGroupId);
            if (result != null) {
                result.Title = moduleGroup.Title;
                result.LecturerGroupModuleGroup = moduleGroup.LecturerGroupModuleGroup;
                result.LecturerModuleGroup = moduleGroup.LecturerModuleGroup;
                result.ModuleRuns = moduleGroup.ModuleRuns;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
