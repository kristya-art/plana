using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Plana.Models
{
    public class StudyBranch
    {
        [Key]
        public int StudyBranchId { get; set; }
        //1-many
      //  public HashSet<Module> Modules = new HashSet<Module>();
      public ICollection<Module> Modules { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
    }
}
