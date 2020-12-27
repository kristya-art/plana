using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class LecturerSemesterDto
    {
        public int LecturerId { get; set; }
        public virtual EditLecturerModel Lecturer { get; set; }

        public int SemesterId { get; set; }
        public virtual SemesterDto Semester { get; set; }
    }
}
