using System;
using System.Collections.Generic;

namespace Plana.Models
{
    public class ModuleGroup : ISoftDelete
    {
        public int ModuleGroupId { get; set; }

        public string Title { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTime? DeletedAt { get; set; }

        public ICollection<ModuleRun> ModuleRuns { get; set; }
        
        public ICollection<LecturerGroupModuleGroup> LecturerGroupModuleGroup { get; set; }

        public ICollection<LecturerModuleGroup> LecturerModuleGroup { get; set; }
    }
}
