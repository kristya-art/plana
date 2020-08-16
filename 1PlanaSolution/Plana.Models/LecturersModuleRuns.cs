using System.ComponentModel.DataAnnotations;

namespace Plana.Models
{
    public class LecturersModuleRuns
    {

        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }


        public int ModuleRunId { get; set; }
        public ModuleRun ModuleRun { get; set; }

    }
}