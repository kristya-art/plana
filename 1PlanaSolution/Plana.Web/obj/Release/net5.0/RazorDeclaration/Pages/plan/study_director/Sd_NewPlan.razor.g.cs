// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Plana.Web.Pages.plan.study_director
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Plana.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Plana.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Plana.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using Plana.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\Sd_NewPlan.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\Sd_NewPlan.razor"
using Plana.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sd_NewPlan")]
    public partial class Sd_NewPlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\Sd_NewPlan.razor"
       

    PlanDto selectedPlan = null;
    PlanDto tempPlan = null;
    bool _isDelete = false;
    bool dialogIsOpen = false;
    bool _isEdit = false;

    bool snackBar = false;





    #region Methods

    #endregion

    #region Dialog Box Methods
    private void OpenDialog(bool isEdit)
    {
        _isEdit = isEdit;
        //if (!_isEdit) plan = new Plan();
        dialogIsOpen = true;
    }
    private void okCklick()
    {
        dialogIsOpen = false;

    }
    private void CloseDialog()
    {
        dialogIsOpen = false;
        if (selectedPlan != null)
        {
            plan = selectedPlan;
            //this.EditPlan(selectedPlan);
        }
    }
    #endregion

    [Inject]
    public IPlanService PlanService { get; set; }
    [Inject]
    public ISemesterService SemesterService { get; set; }
    [Inject]
    public NavigationManager NavManager { get; set; }

    PlanDto plan { get; set; } = new PlanDto();




    SemesterDto Ssemester { get; set; } = new SemesterDto();

    
    SemesterDto Asemester { get; set; } = new SemesterDto();

   

    async Task Create()
    {



        plan.SpringSemester = Ssemester;

        plan.AutumnSemester = Asemester;


        plan = await PlanService.CreatePlan(plan);
        //await SemesterService.UpdateSemester(plan.SpringSemester);
        //await SemesterService.UpdateSemester(plan.AutumnSemester);
        NavManager.NavigateTo($"/editplan/{plan.Id}", true);
        dialogIsOpen = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591