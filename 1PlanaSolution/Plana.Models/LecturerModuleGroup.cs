namespace Plana.Models
{
    public class LecturerModuleGroup
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public int ModuleGroupId { get; set; }
        public ModuleGroup ModuleGroup { get; set; }
    }
}