using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface IAdditionalAssignmentRepository
    {
        Task<IEnumerable<AdditionalAssignment>> Search(string name);

        Task<IEnumerable<AdditionalAssignment>> GetAdditionalAssignments();
        Task<AdditionalAssignment> GetAdditionalAssignment(int additionalAssignmentId);
        Task<AdditionalAssignment> CreateAdditionalAssignment(AdditionalAssignment additionalAssignment);
       
        Task<Boolean> DeleteAdditionalAssignment(int additionalAssignmentId);
        Task<AdditionalAssignment> UpdateAdditionalAssignment(AdditionalAssignment additionalAssignment);
        Task<Boolean> SoftDeleteAdditionalAssignment(int additionalAssignmentId);
       

    }
}
