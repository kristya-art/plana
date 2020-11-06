using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class LecturersModulesRepository : ILecturersModulesRepository
    {
        private readonly AppDbContext context;
        public LecturersModulesRepository(AppDbContext appDbContext) {

            this.context = appDbContext;
        }

        public IEnumerable<LecturerModule> LecturersModules =>
            context.LecturersModules.Include(l => l.Lecturer)
            .Include(m => m.Module);
        public Task<LecturerModule> CreateLecturersModules(Lecturer lectuer, Module module)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LecturerModule>> GetAll()
        {
            return await context.LecturersModules
                  .Include(l => l.Lecturer)
                  .Include(m => m.Module).ToListAsync();


        }

        public Task<LecturerModule> UpdateLecturersModules(int lecturerId, int moduleId)
        {
            throw new NotImplementedException();
        }
    }

      

       
        

       
    }

