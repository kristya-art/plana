using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
    public class LecturerGroup : ISoftDelete
    {
        public int LecturerGroupId { get; set; }
        public string Title { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<LecturerLecturerGroup> LecturerLecturerGroup{ get; set; }
        public  ICollection<LecturerGroupModuleGroup> LecturerGroupModuleGroup { get; set; }
       //[parent]
        public ICollection<LecturerGroup> LecturerSubGroups { get; set; }
        
    }
}
