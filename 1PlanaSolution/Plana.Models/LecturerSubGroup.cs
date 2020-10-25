using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
   public class LecturerSubGroup
    {
        public int LecturerSubGroupId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<LecturerLecturerSubGroup> LecturerLSG { get; set; }
        public ICollection<ModuleRunLecturerSubGroup> ModuleRunsLSG { get; set; }
        public LecturerGroup LecturerGroup { get; set; }
    }
}
