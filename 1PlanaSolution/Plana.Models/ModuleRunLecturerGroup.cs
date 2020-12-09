using Plana.Models;

namespace Plana.Api.Models
{
    public class ModuleRunLecturerGroup
    {
        public int ModuleRunId { get; set; }
        public ModuleRun ModuleRun { get; set; }
        public int LecturerGroupId { get; set; }
        public LecturerGroup LecturerGroup { get; set; }

    }
}