#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed4ed623c633639bc9a07d5cf2360cef58d95ff"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
using Plana.Web.Pages.plan.study_director;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editplan/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editplan")]
    public partial class EditPlan : EditPlanBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
 if (Plan == null || Plans == null) { return; }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>EditPlan</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                  Plan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "year");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                                          Plan.Year

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Plan.Year = __value, Plan.Year))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Plan.Year));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n\r\n\r\n\r\n\r\n    table\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 100 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
 if (Plan == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "Loading...");
#nullable restore
#line 102 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                           
}
else
{

    

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, @"<thead>
            <tr>
                
                
                <th>Semester</th>
                <th>Module</th>
                <th>Module Title</th>
                <th>Module-Group</th>
                <th>Place</th>
                <th>Module Total Hours</th>
                <th>Lecturers Group</th>
                <th>Lecturers</th>
                <th>Set Lecturers hours</th>
                <th>Actions</th>
                <th>notes</th>
            </tr>
            
        </thead>
        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n\r\n");
#nullable restore
#line 129 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
             if (Plan.Semesters != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "            <tr></tr>\r\n");
#nullable restore
#line 133 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                 foreach (var sem in Plan.Semesters)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 136 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                     sem.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 137 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                 if (sem.ModuleRuns != null)
                   {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                     foreach (var mr in sem.ModuleRuns)
                      {


#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 142 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                             mr.Module.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 143 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                             mr.Module.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 144 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                             mr.ModuleGroup

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 145 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                             mr.Place

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 146 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                             mr.Module.TotalHours

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 147 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"

                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                       
                
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 152 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
                 
            
            }
                

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 205 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.AddMarkupContent(55, @"<style>
    .table {
        font-family: 'ArialMT', 'Arial';
        font-weight: 400;
        font-style: normal;
        font-size: 13px;
        letter-spacing: normal;
        color: #333333;
        vertical-align: none;
        text-align: center;
        line-height: normal;
        text-transform: none;
    }
    .table th {
        padding: 2px;
       
    }
    .table tr {

    }
   .table  td {
        text-align: center;
    }
    .table tr:hover {
        background-color: #ddd;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 208 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
       
    //[Inject]
    //public IPlanService PlanService { get; set; }

    //public Plan Plan { get; set; } = new Plan();

    //public List<Plan> Plans { get; set; } = new List<Plan>();

    //[Parameter]
    //public string Id { get; set; }

    //protected async override Task OnInitializedAsync()
    //{
    //    int.TryParse(Id, out int planId);

    //    if (planId != 0)
    //    {
    //        Plan = await PlanService.GetPlan(int.Parse(Id));
    //    }

    //    else
    //    {
    //        Plan = new Plan { };



    //    }
    //    Plans = (await PlanService.GetPlans()).ToList();

    //}

    //protected async Task HandleValidSubmit()
    //{
    //    Plan result = null;
    //    if (Plan.Id != 0)
    //    {
    //        await PlanService.UpdatePlan(Plan);
    //    }
    //    else
    //    {
    //        result = await PlanService.CreatePlan(Plan);
    //    }

    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
