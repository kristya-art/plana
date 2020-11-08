using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerSemesterRepository : ILecturerSemesterRepository
    {
        private readonly AppDbContext context;


        public LecturerSemesterRepository(AppDbContext context)
        {
            this.context=context;
        }
        public async Task<LecturerSemester> AddLecturerSemester(LecturerSemester lecturerS)
        {
            var result = await context.LecturerSemesters.AddAsync(lecturerS);


            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> DeleteLecturerSemester(int lecturerSId)
        {
            var result = await GetLecturerSemester(lecturerSId);
            if (result != null)
            {
                context.LecturerSemesters.Remove(result);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<LecturerSemester> GetLecturerSemester(int lecturerSId)
        {
            return await GetLecturerSemester(lecturerSId);
            
        }

        public async Task<IEnumerable<LecturerSemester>> GetLecturerSemesters()
        {
            return await context.LecturerSemesters.ToListAsync();
        }

        public Task<IEnumerable<LecturerSemester>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteLecturer(int lecturerSId)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> SoftDeleteLecturer(int lecturerSId)
        //{
        //    var result = await GetLecturerSemester(lecturerSId);
        //    if (result != null)
        //    {
        //        result.IsDeleted = true;
        //        result.DeletedAt = DateTime.Now.Date;


        //        context.LecturerSemesters.Update(result);
        //        await context.SaveChangesAsync();

        //        return true;
        //    }

        //    return false;
        //}

        public async Task<LecturerSemester> UpdateLecturerSemester(LecturerSemester lecturerS)
        {
            var result = await GetLecturerSemester(lecturerS.LecturerId);
            if (result != null)
            {
                result.Lecturer = lecturerS.Lecturer;
                result.Semester = lecturerS.Semester;

                await context.SaveChangesAsync();

                return result;
                    
            }
            return null;
        }
    }
}
