using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Api.Repositories
{
    public interface IPlanService
    {
        Task MakePlan( Lecturer l, ModuleRun mr, AdditionalAssignment aa);
    }
}
