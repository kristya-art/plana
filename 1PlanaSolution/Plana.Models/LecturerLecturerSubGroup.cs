using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
   public class LecturerLecturerSubGroup
    {
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public int LecturerSubGroupId { get; set; }
        public LecturerSubGroup LecturerSubGroup { get; set; }
    }
}
