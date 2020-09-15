using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public interface IStudyBranchRepository
    {
       
        Task<IEnumerable<StudyBranch>> GetStudyBranches();
        Task<StudyBranch> GetStudyBranch(int studyBranchId);
        Task<StudyBranch> CreateStudyBranch(StudyBranch studyBranch);
        Task<StudyBranch> UpdateStudyBranch(StudyBranch studyBranch);
        Task<Boolean> SoftDeleteStudyBranch(int studyBranchId);
        Task<Boolean> DeleteStudyBranch(int studyBranchId);
        Task<IEnumerable<StudyBranch>> Search(string name, string code);
    }
}
