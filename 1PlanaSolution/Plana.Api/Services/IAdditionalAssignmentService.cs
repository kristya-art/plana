using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IAdditionalAssignmentService
    {
        Task<IEnumerable<AdditionalAssignment>> Search(string name);

        Task<IEnumerable<AdditionalAssignmentDto>> GetAdditionalAssignments();

        Task<AdditionalAssignmentDto> GetAdditionalAssignment(int additionalAssignmentId);

        Task<AdditionalAssignmentDto> CreateAdditionalAssignment(AdditionalAssignmentDto additionalAssignmentDto);
       
        Task<bool> DeleteAdditionalAssignment(int additionalAssignmentId);

        Task<AdditionalAssignmentDto> UpdateAdditionalAssignment(AdditionalAssignmentDto additionalAssignmentDto);
        
       

    }
}
