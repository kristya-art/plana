using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class ModuleRunRepository : IModuleRunRepository
    {
        private readonly AppDbContext appDbContext;

        public ModuleRunRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IQueryable<ModuleRun> ModuleRuns => appDbContext.ModuleRuns;

        public Task<ModuleRun> CreateModuleRun(ModuleRun moduleRun)
        {
            throw new NotImplementedException();
        }

        public Task<ModuleRun> GetModuleRun(int moduleRunId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ModuleRun>> GetModuleRuns()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ModuleRun>> Search(string title, string code)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteModuleRun(int moduleRunId)
        {
            throw new NotImplementedException();
        }

        public Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun)
        {
            throw new NotImplementedException();
        }
    }
}
