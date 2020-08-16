namespace Plana.Models
{
    public class LecturersModules
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public int ModuleId {get;set;}
        public Module Module { get; set; }
    }
}
