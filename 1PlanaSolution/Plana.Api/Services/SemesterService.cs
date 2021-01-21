using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SemesterService(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<SemesterDto> CreateSemester(SemesterDto semesterDto)
        {
            var semester = new Semester();
            _mapper.Map(semesterDto, semester);

           var result=await _context.Semesters.AddAsync(semester);
            await _context.SaveChangesAsync();

            return _mapper.Map<SemesterDto>(result.Entity);
        }

       

        public async Task<SemesterDto> GetSemester(int? semesterId)
        {
            var semester = await _context.Semesters.FindAsync(semesterId);
            return _mapper.Map<SemesterDto>(semester);

        
        }

        private Semester NotFound()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SemesterDto>> GetSemesters()
        {
           
            var semesters = await _context.Semesters
                   .Include(i => i.ModuleRuns)
                   
                  
                   
                   
                  .Include( i=> i.LecturersSemesters)
                  .ThenInclude(m => m.Lecturer)
                  .Include(i => i.AdditionalAssignments)



                  //.OrderBy(n => n.Date)
                  .ToListAsync();
            return _mapper.Map<IEnumerable<SemesterDto>>(semesters);
        }



        public async Task<SemesterDto> UpdateSemester(SemesterDto semesterDto)
        {

            var result = await _context.Semesters.FindAsync(semesterDto.SemesterId);


            if (result != null)
            {
                result.Code = semesterDto.Code;
                result.Date = semesterDto.Date;
                

                await _context.SaveChangesAsync();

                return _mapper.Map<SemesterDto>(result);
            }
            return null;
        
        }

        public async Task<bool> DeleteSemester(int semesterId)
        {
            var result = await _context.Semesters.FindAsync(semesterId);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }
       
        public Task<IEnumerable<Semester>> Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
