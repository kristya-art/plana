using System;

namespace Plana.Models
{
    public class LecturerModule : ISoftDelete
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public int ModuleId {get;set;}
        public virtual Module Module { get; set; }

        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
