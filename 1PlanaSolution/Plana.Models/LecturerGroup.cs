using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
    public class LecturerGroup : ISoftDelete
    {
        public int LecturerGroupId { get; set; }
        public string Title { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LecturerLecturerGroup> LecturerLecturerGroup{ get; set; }
        public virtual  ICollection<LecturerGroupModuleGroup> LecturerGroupModuleGroup { get; set; }
       //[parent]
        public virtual ICollection<LecturerGroup> LecturerSubGroups { get; set; }
        public virtual ICollection<ModuleRunLecturerGroup> ModuleRunLecturerGroups { get; set; }

    }
}
