namespace Plana.Models
{
    public class LecturerSemester
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }

    }
}