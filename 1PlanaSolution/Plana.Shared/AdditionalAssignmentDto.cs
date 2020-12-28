using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plana.Shared
{
    public class AdditionalAssignmentDto : PlanaEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double AAHours { get; set; }

        public int? LecturerId { get; set; } 

        public int? SemesterId { get; set; } 

        public AdditionalAssignmentCategoryDto AACategory { get; set; }
    }
}
