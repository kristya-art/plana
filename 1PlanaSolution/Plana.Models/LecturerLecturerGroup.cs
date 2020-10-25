using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
   public class LecturerLecturerGroup
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public int LecturerGroupId { get; set; }
        public LecturerGroup LecturerGroup { get; set; }


    }
}
