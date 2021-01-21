using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
  public  class LecturerGroupDto
    {
        public int LecturerGroupId { get; set; }
        public string Title { get; set; }
        
        public virtual ICollection<LecturerLecturerGroupDto> LecturerLecturerGroup { get; set; }
        public virtual ICollection<LecturerGroupModuleGroupDto> LecturerGroupModuleGroup { get; set; }
        
        public virtual ICollection<LecturerGroupDto> LecturerSubGroups { get; set; }
        public virtual ICollection<ModuleRunLecturerGroupDto> ModuleRunLecturerGroups { get; set; }

    }
}
