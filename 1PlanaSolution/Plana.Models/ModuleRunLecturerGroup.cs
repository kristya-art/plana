using Plana.Models;
using System;

namespace Plana.Api.Models
{
    public class ModuleRunLecturerGroup : ISoftDelete
    {
        public int ModuleRunId { get; set; }

        public virtual ModuleRun ModuleRun { get; set; }

        public int LecturerGroupId { get; set; }

        public virtual LecturerGroup LecturerGroup { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}