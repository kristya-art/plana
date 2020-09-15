using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Plana.Models
{
  public class AdditionalAssignment : ISoftDelete{ 
        [Key]
        public int AdditionalAssignmentId { get; set; }
        public string Title { get; set; }
        public double AAHours { get; set; }
        public Lecturer Lecturer { get; set; }
        public Semester Semester { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
