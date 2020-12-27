using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class LecturerModuleGroupDto
    {
        public int LecturerId { get; set; }
        public virtual EditLecturerModel Lecturer { get; set; }
        public int ModuleGroupId { get; set; }
        public virtual ModuleGroupDto ModuleGroup { get; set; }
    }
}
