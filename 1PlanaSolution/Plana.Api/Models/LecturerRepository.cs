using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class LecturerRepository : ILecturerRepository
    {
        private readonly AppDbContext appDbContext;
 

        public LecturerRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public  IEnumerable<Lecturer> Teachers =>
            appDbContext.Lecturers.Include(m => m.LecturersModules).ThenInclude(mo => mo.Module);

        public async Task<Lecturer> AddLecturer(Lecturer lecturer)
        {
            var result = await appDbContext.Lecturers.AddAsync(lecturer);
           
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

      //  public async Task<Lecturer> DeleteLecturer(int lecturerId)
        public async Task<Boolean> DeleteLecturer(int lecturerId)
        {
            var result = await appDbContext.Lecturers
                 .FirstOrDefaultAsync(e => e.LecturerId == lecturerId);
            if (result != null)
            {
                appDbContext.Lecturers.Remove(result);
                await appDbContext.SaveChangesAsync();
                // return result;
                return true; // if i use true, then i use Task<bool>
            }
            // return null; // if use bool, then here false
            return false;
        }
        /**  soft delete */
        public async Task<Boolean> SoftDeleteLecturer(int lecturerId)
        {
            var result = await appDbContext.Lecturers
                .FirstOrDefaultAsync(e => e.LecturerId == lecturerId);
            if (result != null)
            {
                result.IsDeleted = true;

                appDbContext.Lecturers.Update(result);
                await appDbContext.SaveChangesAsync();

                return true;
            }

            return false;

        }

        public async Task<Lecturer> GetLecturer(int lecturerId)
        {
            return await appDbContext.Lecturers
               //  .Include(e=>e.LecturersModules)
             
                 .FirstOrDefaultAsync(e => e.LecturerId == lecturerId);
        }

        public async Task<IEnumerable<Lecturer>> GetLecturers()
        {
              return await appDbContext.Lecturers.ToListAsync();
            
        }

        public async Task<IEnumerable<Lecturer>> Search(string name, Gender? gender)
        {
            IQueryable<Lecturer> query = appDbContext.Lecturers;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name)
                        || e.LastName.Contains(name));
            }
            if (gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }
            return await query.ToListAsync();
        }

        public async Task<Lecturer> UpdateLecturer(Lecturer lecturer)
        {
            var result = await appDbContext.Lecturers
                .FirstOrDefaultAsync(e => e.LecturerId == lecturer.LecturerId);
            if (result != null)
            {
                result.FirstName = lecturer.FirstName;
                result.LastName = lecturer.LastName;
                
                result.Token = lecturer.SetTocken();
                result.Email = lecturer.Email;
                //result.Password = lecturer.Password
                result.BirthDate = lecturer.BirthDate;
                result.Gender = lecturer.Gender;
                result.PhotoPath = lecturer.PhotoPath;
                result.ActiveTill = lecturer.ActiveTill;
                result.IsActive = lecturer.IsActive;

                result.LecturersModules = lecturer.LecturersModules;//new
                
               
                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
               
        }

        public async Task<IEnumerable<Lecturer>> GetLecturersModules()
        {
            return await appDbContext.Lecturers
                .Include(m => m.LecturersModules)
                .ThenInclude(mo => mo.Module).ToListAsync();
        }
    }
}
