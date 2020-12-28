using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class LecturerLecturerGroupDto
    {
        public int LecturerId { get; set; }
        public virtual LecturerDto Lecturer { get; set; }
        public int LecturerGroupId { get; set; }
        public virtual LecturerGroupDto LecturerGroup { get; set; }
    }
}
