using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class LecturerModuleDto
    {
        public int LecturerId { get; set; }
        public virtual EditLecturerModel Lecturer { get; set; }
        public int ModuleId { get; set; }
        public virtual ModuleDto Module { get; set; }
    }
}
