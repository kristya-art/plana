using System;
using System.Collections.Generic;
using System.Text;

namespace Plana.Models
{
    public class ModuleRunLecturerSubGroup
    {
        public int ModuleRunId { get; set; }
        public ModuleRun ModuleRun { get; set; }
        public int LecturerSubGroupId { get; set; }
        public LecturerSubGroup LecturerSubGroup { get;set;}
    }
}
