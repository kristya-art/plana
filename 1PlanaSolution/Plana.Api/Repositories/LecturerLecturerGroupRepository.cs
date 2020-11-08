using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerLecturerGroupRepository : ILecturerLecturerGroupRepository
    {

        private readonly AppDbContext context;


        public LecturerLecturerGroupRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<LecturerLecturerGroup> AddLecturerLecturerGroup(LecturerLecturerGroup lecturerLecturerGroup)
        {
            var result = await context.LecturerLecturerGroups.AddAsync(lecturerLecturerGroup);


            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<LecturerLecturerGroup> GetLecturerLecturerGroup(int lecturerLecturerGroupId)
        {
            return await context.LecturerLecturerGroups.FindAsync(lecturerLecturerGroupId);

        }

        public async Task<IEnumerable<LecturerLecturerGroup>> GetLecturerLecturerGroups()
        {
            return await context.LecturerLecturerGroups
               .Include(i=>i.Lecturer)
               .Include(i => i.LecturerGroup)
               .ToListAsync();
        }

        public async Task<LecturerLecturerGroup> UpdateLecturerLecturerGroup(LecturerLecturerGroup lecturerLecturerGroup)
        {
            var result = await GetLecturerLecturerGroup(lecturerLecturerGroup.LecturerId);
            if (result != null)
            {
                result.Lecturer = lecturerLecturerGroup.Lecturer;
                result.LecturerGroup = lecturerLecturerGroup.LecturerGroup;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
