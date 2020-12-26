namespace Plana.Models
{
    public class LecturerGroupModuleGroup
    {
        public int LecturerGroupId { get; set; }
        public int ModuleGroupId { get; set; }

        public virtual LecturerGroup LecturerGroup {get;set;}
        public virtual  ModuleGroup ModuleGroup {get;set;}
    }
}