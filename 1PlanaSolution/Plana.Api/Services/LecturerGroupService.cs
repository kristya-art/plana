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
    public class LecturerGroupService : ILecturerGroupService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public LecturerGroupService(AppDbContext context, IMapper mapper)
        {
            _context = context;

            _mapper = mapper;
        }




        public async Task<bool> DeleteLecturerGroup(int lecturerGroupId)
        {
            var result = await _context.LecturerGroups.FindAsync(lecturerGroupId);
            if (result != null)
            {
                _context.LecturerGroups.Remove(result);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<LecturerGroupDto> GetLectureGroup(int lecturerGroupId)
        {
            var lecturergroup = await _context.LecturerGroups.FindAsync(lecturerGroupId);
            return _mapper.Map<LecturerGroupDto>(lecturergroup);
        }

        public async Task<IEnumerable<LecturerGroupDto>> GetLecturerGroups()
        {
            var lecturergroups = await _context.LecturerGroups.ToListAsync();
            return _mapper.Map<IEnumerable<LecturerGroupDto>>(lecturergroups);
        }

        public async Task<ActionResultDto<LecturerGroupDto>> AddLecturerGroup(LecturerGroupDto lecturerGroupDto)
        {
            var lecturergroup = new LecturerGroup();
            _mapper.Map(lecturerGroupDto, lecturergroup);
            if(lecturergroup == null ) { return new ActionResultDto<LecturerGroupDto>("You can not add an empty lecturer group "); }
            foreach (var lg in _context.LecturerGroups) {
                if (lg.Title == lecturergroup.Title) {
                    return new ActionResultDto<LecturerGroupDto>("The group is already has been added.");
                }
            }
            var result = await _context.LecturerGroups.AddAsync(lecturergroup);
            await _context.SaveChangesAsync();
            return _mapper.Map<LecturerGroupDto>(result.Entity);
        }


       

        public async Task<LecturerGroupDto?> UpdateLecturerGroup(LecturerGroupDto lecturerGroupDto)
        {
            var result = await _context.LecturerGroups.FindAsync(lecturerGroupDto.LecturerGroupId);

            if (result != null)
            {
                result.Title = lecturerGroupDto.Title;

                await _context.SaveChangesAsync();

                return _mapper.Map<LecturerGroupDto>(result);
            }
            return null;
        }

        public Task<IEnumerable<LecturerGroup>> Search(string name)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<LecturerGroupDto>> ILecturerGroupService.Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
