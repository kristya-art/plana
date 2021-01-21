using System;

namespace Plana.Models
{
    public class LecturerSemester : ISoftDelete
    {
        public int LecturerId { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public int SemesterId { get; set; }

        public virtual Semester Semester { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}