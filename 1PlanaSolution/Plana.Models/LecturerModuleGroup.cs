using System;

namespace Plana.Models
{
    public class LecturerModuleGroup : ISoftDelete
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public int ModuleGroupId { get; set; }
        public virtual ModuleGroup ModuleGroup { get; set; }

        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}