using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
   public class LecturerGroupModuleGroupDto
    {
        public int LecturerGroupId { get; set; }
        public int ModuleGroupId { get; set; }
        public virtual LecturerGroupDto LecturerGroup { get; set; }
        public virtual ModuleGroupDto ModuleGroup { get; set; }
    }
}
