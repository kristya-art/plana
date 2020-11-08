using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class AdditionalAssignmentRepository : IAdditionalAssignmentRepository
    {
        private readonly AppDbContext context;

        public AdditionalAssignmentRepository(AppDbContext context) {
            this.context = context;
        }
        public async Task<AdditionalAssignment> CreateAdditionalAssignment(AdditionalAssignment additionalAssignment)
        {
            var result=await context.AdditionalAssignments.AddAsync(additionalAssignment);

            await context.SaveChangesAsync();
            return result.Entity;
        }

        

        public async Task<AdditionalAssignment> GetAdditionalAssignment(int additionalAssignmentId)
        {
            return await context.AdditionalAssignments.FindAsync(additionalAssignmentId);
        }

        public async Task<IEnumerable<AdditionalAssignment>> GetAdditionalAssignments()
        {
            return await context.AdditionalAssignments.ToListAsync();
        }

       

        public async Task<bool> SoftDeleteAdditionalAssignment(int additionalAssignmentId)
        {
            var result = await context.AdditionalAssignments.FindAsync(additionalAssignmentId);
            if (result != null) {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.AdditionalAssignments.Update(result);
                await context.SaveChangesAsync();

                return true;

            }
            return false;
        }

        public async Task<AdditionalAssignment> UpdateAdditionalAssignment(AdditionalAssignment additionalAssignment)
        {
            var result = await context.AdditionalAssignments.FindAsync(additionalAssignment.AdditionalAssignmentId);
            if (result != null) {
                result.Title = additionalAssignment.Title;
                result.AAHours = additionalAssignment.AAHours;
                result.Description = additionalAssignment.Description;
                // have to put also category after db-update
                
                await context.SaveChangesAsync();
                return result;

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
        public async Task<bool> DeleteAdditionalAssignment(int additionalAssignmentId)
        {
            throw new NotImplementedException();
        }
    }
}
