#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88142c5991f1631b6f62141d4ce4e4c0e78c6443"
// <auto-generated/>
#pragma warning disable 1591
namespace Plana.Web.Pages.plan.navMenus
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
#line 12 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lcustomSelect")]
    public partial class LCustomSelect : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
 if (Plans == null)
{ return; }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
                                        SelectedPlan.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedPlan.Id = __value, SelectedPlan.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 8 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
         foreach (var plan in Plans)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 10 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
                            plan.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
                 plan.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 13 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "btn-group");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
                          NavigateToMyPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n            My plan\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(25, "<style>\r\n    form {\r\n        padding: 2px;\r\n    }\r\n\r\n    input {\r\n        /* And hide the input\'s outline, so the form looks like the outline */\r\n        border: none;\r\n    }\r\n\r\n\r\n   \r\n   \r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\navMenus\LCustomSelect.razor"
       

    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    public IPlanService PlanService { get; set; }
    [Parameter]
    public Plan Plan { get; set; } = new Plan();
    [Parameter]
    public Plan SelectedPlan { get; set; } = new Plan();
    //public Plan SelectePlanForShow { get; set; } = new Plan();
    public List<Plan> Plans { get; set; }
    



    public string Id { get; set; }

    //protected async override Task OnInitializedAsync()
    //{


    //    Plans = (await PlanService.GetPlans()).ToList();

    //}
    //#region method
    public void NavigateToMyPlan()
    {
        string Id = Plan.Id.ToString();
        NavManager.NavigateTo($"/editplan/{SelectedPlan.Id}", true);
    }




    #region   // for lCustomSelect
    //[Inject]
    //public PlanLecturerService planLecturerService { get; set; }
    //public PlanLecturer PlanLct { get; set; }
    //public Lecturer Lecturer { get; set; } = new Lecturer();

    //public PlanLecturer SelectedPlanLecturer { get; set; } = new PlanLecturer();

    //public List<PlanLecturer> PlanLecturers { get; set; } = new List<PlanLecturer>();

    //public string PlanLectPlanId { get; set; }
    //public string PlanLectLectId { get; set; }

    //protected void override Task OnInizialiedAsync()
    //{
    //    PlanLecturers = (await planLecturersService.GetPlanLecturers());
    //}
    #endregion


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591