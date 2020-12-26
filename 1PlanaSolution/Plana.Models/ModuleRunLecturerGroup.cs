using Plana.Models;

namespace Plana.Api.Models
{
    public class ModuleRunLecturerGroup
    {
        public int ModuleRunId { get; set; }
        public virtual ModuleRun ModuleRun { get; set; }
        public int LecturerGroupId { get; set; }
        public virtual LecturerGroup LecturerGroup { get; set; }

    }
}