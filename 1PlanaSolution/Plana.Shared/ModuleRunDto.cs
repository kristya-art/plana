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
        
        public bool isSelected { get; set; }
        public virtual ICollection<LecturerModuleRunDto> LecturersMR { get; set; }

        public int ModuleId { get; set; } // Foreign key many-to-one

        public int SemesterId { get; set; } //Foreign key many-to-one

        public virtual ModuleGroupDto ModuleGroup { get; set; }


        public virtual ICollection<ModuleRunLecturerGroupDto> ModuleRunLecturerGroups { get; set; }

        public double TotalDesiredHours { get; set; } = 0.0;
        public double GetTotalDesiredHours() {
            TotalDesiredHours = 0.0;
            foreach (var l in LecturersMR) {
                
                TotalDesiredHours += l.DesiredHours;
            
            }
            return TotalDesiredHours;
        }

        public bool IsExceedingHours() {
            TotalDesiredHours = GetTotalDesiredHours();
            if (Module.TotalHours!= 0 && TotalDesiredHours > Module.TotalHours) {
                return true;
            }
            return false;
        }
        public double TotalSetHours{ get; set; } = 0.0;
        public double GetTotalSetHours()
        {
            TotalSetHours = 0.0;
            foreach (var l in LecturersMR)
            {

                TotalSetHours += l.Hours;

            }
            return TotalSetHours;
        }

        public bool IsExceedingSetHours()
        {
           TotalSetHours = GetTotalSetHours();
            if (Module.TotalHours != 0 && TotalSetHours > Module.TotalHours)
            {
                return true;
            }
            return false;
        }

        public double HoursToPlan() {
            double HoursToPlan = 0.0;
            TotalSetHours = GetTotalSetHours();
            if (Module.TotalHours!= 0) {
                HoursToPlan = Module.TotalHours - TotalSetHours;
               
            }
            return HoursToPlan;
        }

    }
}
