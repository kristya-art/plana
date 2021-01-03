using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class LecturerModuleRunDto
    {
        public int LecturerId { get; set; }
        public virtual LecturerDto Lecturer { get; set; }

        /// <summary>
        /// Gets or sets number of lessons per week.
        /// </summary>
        public int Lessons { get; set; }

        public int ModuleRunId { get; set; }
        public virtual ModuleRunDto ModuleRun { get; set; }
        public double Hours { get; set; }
        public double DesiredHours { get; set; }
        public string Notes { get; set; }

        


    }
}
