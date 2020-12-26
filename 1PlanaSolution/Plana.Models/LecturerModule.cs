namespace Plana.Models
{
    public class LecturerModule
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public int ModuleId {get;set;}
        public virtual Module Module { get; set; }


       
    }
}
