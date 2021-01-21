using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class ModuleGroupDto 
    {
        public int ModuleGroupId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<ModuleRunDto> ModuleRuns { get; set; }

        public virtual ICollection<LecturerGroupModuleGroupDto> LecturerGroupModuleGroup { get; set; }

        public virtual ICollection<LecturerModuleGroupDto> LecturerModuleGroup { get; set; }
    }
}
