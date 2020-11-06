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

        public ICollection<LecturerLecturerGroup> LecturerLG { get; set; }
        public LecturerGroupModuleGroup Lecturer_ModuleGroup { get; set; }
        
    }
}
