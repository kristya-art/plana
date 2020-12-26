using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
   public class LecturerLecturerGroup
    {
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public int LecturerGroupId { get; set; }
        public virtual LecturerGroup LecturerGroup { get; set; }


    }
}
