using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Shared;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Plana.Api.Services
{
    public class LecturerLecturerGroupService : ILecturerLecturerGroupService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public LecturerLecturerGroupService(AppDbContext context, IMapper mapper)
        {
            _context = context;

            _mapper = mapper;
        }




        public async Task<bool> DeleteLecturerLecturerGroup(int lecturerId, int lecturerGroupId)
        {
            var result = await _context.LecturerLecturerGroups.FindAsync(lecturerId, lecturerGroupId);
            if (result != null)
            {
                _context.LecturerLecturerGroups.Remove(result);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<LecturerLecturerGroupDto> GetLectureLecturerGroup(int lecturerId, int lecturerGroupId)
        {
            var LecturerLecturerGroup = await _context.LecturerLecturerGroups.FindAsync(lecturerId,lecturerGroupId);
            return _mapper.Map<LecturerLecturerGroupDto>(LecturerLecturerGroup);
        }

        public async Task<IEnumerable<LecturerLecturerGroupDto>> GetLecturerLecturerGroups()
        {
            var LecturerLecturerGroups = await _context.LecturerLecturerGroups.ToListAsync();
            return _mapper.Map<IEnumerable<LecturerLecturerGroupDto>>(LecturerLecturerGroups);
        }

        public async Task<ActionResultDto<LecturerLecturerGroupDto>> AddLecturerLecturerGroup(LecturerLecturerGroupDto LecturerLecturerGroupDto)
        {
            var LecturerLecturerGroup = new LecturerLecturerGroup();
            _mapper.Map(LecturerLecturerGroupDto, LecturerLecturerGroup);

            if (LecturerLecturerGroup == null) { return new ActionResultDto<LecturerLecturerGroupDto>("You can not add an empty lecturer group "); }

            bool containsLecturer = await _context.LecturerLecturerGroups.ContainsAsync(LecturerLecturerGroup);

            if (containsLecturer)
            {
                return new ActionResultDto<LecturerLecturerGroupDto>("Lecturer has already been added.");
            }

            var result = await _context.LecturerLecturerGroups.AddAsync(LecturerLecturerGroup);
            await _context.SaveChangesAsync();

            return _mapper.Map<LecturerLecturerGroupDto>(result.Entity);
        }




        public async Task<LecturerLecturerGroupDto?> UpdateLecturerLecturerGroup(LecturerLecturerGroupDto LecturerLecturerGroupDto)
        {
            var result = await _context.LecturerLecturerGroups.FindAsync(LecturerLecturerGroupDto.LecturerId,LecturerLecturerGroupDto.LecturerGroupId);

            if (result != null)
            {
                result.LecturerGroupId= LecturerLecturerGroupDto.LecturerGroupId;
                result.LecturerId = LecturerLecturerGroupDto.LecturerId;
                

                await _context.SaveChangesAsync();

                return _mapper.Map<LecturerLecturerGroupDto>(result);
            }
            return null;
        }

   }
}
