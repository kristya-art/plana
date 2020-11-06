namespace Plana.Models
{
    public class LecturerGroupModuleGroup
    {
        public int LecturerGroupId { get; set; }
        public int ModuleGroupId { get; set; }

        public LecturerGroup LecturerGroup {get;set;}
        public ModuleGroup ModuleGroup {get;set;}
    }
}