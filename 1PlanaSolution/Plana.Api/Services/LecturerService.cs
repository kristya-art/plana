using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;
using AutoMapper;
using Plana.Api.Models;

namespace Plana.Api.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;
 

        public LecturerService(AppDbContext appDbContext, IMapper mapper)
        {
            this.appDbContext = appDbContext;

            this.mapper = mapper;
        }


        //public  IEnumerable<LecturerDto> Teachers =>
        //    appDbContext.Lecturers.Include(m => m.LecturersModules).ThenInclude(mo => mo.Module);

        public async Task<LecturerDto> AddLecturer(LecturerDto lecturerDto)
        {
            var lecturer = new Lecturer();
            lecturerDto.SetToken();
            mapper.Map(lecturerDto, lecturer);

            var result = await appDbContext.Lecturers.AddAsync(lecturer);
            await appDbContext.SaveChangesAsync();

            return mapper.Map<LecturerDto>(result.Entity);
        }
        
        public async Task<LecturerDto> GetLecturer(int lecturerId)
        {
            var lecturer =  await appDbContext.Lecturers.FindAsync(lecturerId);
            return mapper.Map<LecturerDto>(lecturer);
        }

        public async Task<IEnumerable<LecturerDto>> GetLecturers()
        {
            var lecturers = await appDbContext.Lecturers.ToListAsync();
            return mapper.Map<IEnumerable<LecturerDto>>(lecturers);
            
        }

       

        public async Task<LecturerDto?> UpdateLecturer(LecturerDto lecturerDto)
        {
            var result = await GetLecturer(lecturerDto.Id);
            if (result != null) 
            {
                result.FirstName = lecturerDto.FirstName;
                result.LastName = lecturerDto.LastName;
                result.Token = lecturerDto.Token;
                result.Email = lecturerDto.Email;
                //result.Password = lecturerDto.Password
                result.BirthDate = lecturerDto.BirthDate;
                result.Gender = lecturerDto.Gender;
                result.PhotoPath = lecturerDto.PhotoPath;
                result.ActiveTill = lecturerDto.ActiveTill;
                result.IsActive = lecturerDto.IsActive;
                result.WorkingRate = lecturerDto.WorkingRate;
                result.LecturersModules = lecturerDto.LecturersModules;//new
               
                result.AdditionalAssignments = lecturerDto.AdditionalAssignments;//new
                result.LecturersModuleRuns = lecturerDto.LecturersModuleRuns;
               

                await appDbContext.SaveChangesAsync();

                return mapper.Map<LecturerDto>(result);
               
            }

              return null;
        }

       
        public async Task<Boolean> DeleteLecturer(int lecturerId)
        {
            var result = await appDbContext.Lecturers.FindAsync(lecturerId);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now;

                await appDbContext.SaveChangesAsync();

                return true;
            }
          
            return false;
        }

        public async Task<IEnumerable<LecturerDto>> Search(string name, Gender? gender)
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
            var lecturers = await query.ToListAsync();
            return mapper.Map<IEnumerable<LecturerDto>>(lecturers);
            
        }

       
       }
    }

