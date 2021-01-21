using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class StudyBranchDto 
    {
        public int StudyBranchId { get; set; }
        public virtual ICollection<ModuleDto> Modules { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }
    }
}
