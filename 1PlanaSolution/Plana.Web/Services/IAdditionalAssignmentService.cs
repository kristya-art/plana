using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IAdditionalAssignmentService
    {
        Task<IEnumerable<AdditionalAssignmentDto>> GetAdditionalAssignments();
        Task<AdditionalAssignmentDto> GetAdditionalAssignment(int id);
        Task<AdditionalAssignmentDto> UpdateAdditionalAssignment(AdditionalAssignmentDto additionalAssignment);
        Task<AdditionalAssignmentDto> CreateAdditionalAssignment(AdditionalAssignmentDto newAdditionalAssignment);
        Task SoftDeleteAdditionalAssignment(int id);
    }
}
