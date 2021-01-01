using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class ModuleRunDto
    {
        public int ModuleRunId { get; set; }
        //'a', 'b', 'p','q'
        public string Code { get; set; }
        //many-1
        //    public Semester Semester { get; set; }
        //many-1
        public virtual ModuleDto Module { get; set; }

        //Biel, Bern
        public string Place { get; set; }
        public bool Editable { get; set; }
        //1/3, 1/2, 1/4
        //public double ModuleRunRate { get; set; } // maybe better to have it in lecturersmoduleruns
        //many-many
        public virtual ICollection<LecturerModuleRunDto> LecturersMR { get; set; }

        public int ModuleId { get; set; } // Foreign key many-to-one

        public int SemesterId { get; set; } //Foreign key many-to-one

        public virtual ModuleGroupDto ModuleGroup { get; set; }


        public virtual ICollection<ModuleRunLecturerGroupDto> ModuleRunLecturerGroups { get; set; }

    }
}
