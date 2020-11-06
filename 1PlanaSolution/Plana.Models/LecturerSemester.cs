namespace Plana.Models
{
    public class LecturerSemester
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        public int SemesterId { get; set; }
        public Semester Semester { get; set; }

    }
}