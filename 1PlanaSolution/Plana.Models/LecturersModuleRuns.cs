using System.ComponentModel.DataAnnotations;

namespace Plana.Models
{
    public class LecturersModuleRuns
    {

        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        /// <summary>
        /// Gets or sets number of lessons per week.
        /// </summary>
        public int Lessons { get; set; }

        public int ModuleRunId { get; set; }
        public ModuleRun ModuleRun { get; set; }

    }
}