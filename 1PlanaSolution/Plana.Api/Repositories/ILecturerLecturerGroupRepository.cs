using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerLecturerGroupRepository
    {
        Task<IEnumerable<LecturerLecturerGroup>> GetLecturerLecturerGroups();
        Task<LecturerLecturerGroup> GetLecturerLecturerGroup(int lecturerLecturerGroupId);
        Task<LecturerLecturerGroup> AddLecturerLecturerGroup(LecturerLecturerGroup lecturerLecturerGroup);
        Task<LecturerLecturerGroup> UpdateLecturerLecturerGroup(LecturerLecturerGroup lecturerLecturerGroup);
    }
}
