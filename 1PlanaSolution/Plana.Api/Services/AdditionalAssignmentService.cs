using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plana.Api.Models;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class AdditionalAssignmentService : IAdditionalAssignmentService
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public AdditionalAssignmentService(AppDbContext context, IMapper mapper) {
            this.context = context;

            this.mapper = mapper;
        }
        public async Task<AdditionalAssignmentDto> CreateAdditionalAssignment(AdditionalAssignmentDto additionalAssignmentDto)
        {
            var aa = new AdditionalAssignment();
            mapper.Map(additionalAssignmentDto, aa);

            var result=await context.AdditionalAssignments.AddAsync(aa);

            await context.SaveChangesAsync();
            return mapper.Map<AdditionalAssignmentDto>(result.Entity);
        }

        

        public async Task<AdditionalAssignmentDto> GetAdditionalAssignment(int additionalAssignmentId)
        {
           
            var aa = await context.AdditionalAssignments.FindAsync(additionalAssignmentId);
            return mapper.Map<AdditionalAssignmentDto>(aa);
        }

        public async Task<IEnumerable<AdditionalAssignmentDto>> GetAdditionalAssignments()
        {
          var additionalAssignments = await context.AdditionalAssignments.ToListAsync();
            return mapper.Map<IEnumerable<AdditionalAssignmentDto>>(additionalAssignments);
        }

       

        public async Task<bool> DeleteAdditionalAssignment(int additionalAssignmentId)
        {
            var result = await context.AdditionalAssignments.FindAsync(additionalAssignmentId);
            if (result != null) {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

             
                await context.SaveChangesAsync();

                return true;

            }
            return false;
        }

        public async Task<AdditionalAssignmentDto> UpdateAdditionalAssignment(AdditionalAssignmentDto additionalAssignmentDto)
        {
            var result = await context.AdditionalAssignments.FindAsync(additionalAssignmentDto.AdditionalAssignmentId);
            if (result != null) {
                result.Title = additionalAssignmentDto.Title;
                result.AAHours = additionalAssignmentDto.AAHours;
                result.Description = additionalAssignmentDto.Description;
                // have to put also category after db-update
                result.AACategory = (AdditionalAssignmentCategory)additionalAssignmentDto.AACategory;
                await context.SaveChangesAsync();
                return mapper.Map<AdditionalAssignmentDto>(result);

            }
            return null;
        }
        /// <summary>
        /// the methods below need to be done later
        /// </summary>
       
        public async Task<IEnumerable<AdditionalAssignment>> Search(string name)
        {
            throw new NotImplementedException();
        }
        
    }
}
