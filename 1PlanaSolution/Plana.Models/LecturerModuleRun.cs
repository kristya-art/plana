using System;
using System.ComponentModel.DataAnnotations;

namespace Plana.Models
{
    public class LecturerModuleRun : ISoftDelete
    {

        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        /// <summary>
        /// Gets or sets number of lessons per week.
        /// </summary>
        public int Lessons { get; set; }

        public int ModuleRunId { get; set; }
        public virtual ModuleRun ModuleRun { get; set; }
        public int Hours { get; set; }
        public string Notes { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}