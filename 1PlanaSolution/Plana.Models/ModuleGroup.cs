using Castle.Components.DictionaryAdapter;
using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
    public class ModuleGroup : ISoftDelete
    {
        public int ModuleGroupId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<ModuleRun> ModuleRuns { get; set; }
        public LecturerGroupModuleGroup Lecturer_ModuleGroup { get; set; }

        public ICollection<LecturerModuleGroup> LecturerMG { get; set; }

    }
}
