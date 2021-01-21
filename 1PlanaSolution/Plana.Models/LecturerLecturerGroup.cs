using System;


namespace Plana.Models
{
   public class LecturerLecturerGroup : ISoftDelete
    {
        public int LecturerId { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public int LecturerGroupId { get; set; }

        public virtual LecturerGroup LecturerGroup { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }


    }
}
