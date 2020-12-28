using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class ModuleDto : PlanaEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int ECTS;
        public int LectPerWeek { get; set; }
        public double TotalHours { get; set; }
        public virtual ICollection<LecturerModuleDto> Lecturers { get; set; }
        public int? StudyBranchId { get; set; }
    }
}
