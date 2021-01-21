using System;

namespace Plana.Models
{
    public class LecturerGroupModuleGroup : ISoftDelete
    {
        public int LecturerGroupId { get; set; }
        public int ModuleGroupId { get; set; }

        public virtual LecturerGroup LecturerGroup {get;set;}
        public virtual  ModuleGroup ModuleGroup {get;set;}
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}