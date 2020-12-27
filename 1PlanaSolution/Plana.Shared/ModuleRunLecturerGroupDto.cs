using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class ModuleRunLecturerGroupDto
    {
        public int ModuleRunId { get; set; }
        public virtual ModuleRunDto ModuleRun { get; set; }
        public int LecturerGroupId { get; set; }
        public virtual LecturerGroupDto LecturerGroup { get; set; }
    }
}
