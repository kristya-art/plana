namespace Plana.Models
{
    public class LecturerModuleGroup
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public int ModuleGroupId { get; set; }
        public virtual ModuleGroup ModuleGroup { get; set; }
    }
}