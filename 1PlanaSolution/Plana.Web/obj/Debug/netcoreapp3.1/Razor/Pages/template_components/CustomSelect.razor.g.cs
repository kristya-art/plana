#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9aabe08b38b033f3f010a2551c259ba0478d321"
// <auto-generated/>
#pragma warning disable 1591
namespace Plana.Web.Pages.template_components
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customSelect")]
    public partial class CustomSelect : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
 if (Plans == null)
{ return; }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "class", "form-control");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                                    SelectedPlan.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedPlan.Id = __value, SelectedPlan.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 8 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
     foreach (var plan in Plans)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "      ");
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 10 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                      plan.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
             plan.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 13 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatFAB>(14);
            __builder.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
               MatIconNames.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                                         SelectedPlan.Year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenElement(19, "a");
                __builder2.AddAttribute(20, "href", 
#nullable restore
#line 20 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
               $"/editplan/{SelectedPlan.Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(21, "show");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 23 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
 if (Plans == null)
{ return; }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 26 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
 foreach (var plan in Plans)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenComponent<MatBlazor.MatFAB>(26);
            __builder.AddAttribute(27, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                   MatIconNames.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                                             plan.Year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n\r\n        ");
                __builder2.OpenElement(31, "a");
                __builder2.AddAttribute(32, "href", 
#nullable restore
#line 30 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                   $"/editplan/{plan.Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(33, 
#nullable restore
#line 30 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
                                             plan.Year

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 32 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(37, "<style>\r\n    .customS {\r\n        display: table-cell;\r\n        vertical-align: middle;\r\n        height: 50px;\r\n        border: 1px solid #354496;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\CustomSelect.razor"
       
   
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    public IPlanService PlanService { get; set; }
    [Parameter]
    public Plan Plan { get; set; } = new Plan();
    public Plan SelectedPlan { get; set; } = new Plan();
    public List<Plan> Plans { get; set; }



    public string Id { get; set; }

    protected async override Task OnInitializedAsync()
    {

        //Id = Id ?? "1";
        Plans = (await PlanService.GetPlans()).ToList();
        //Plan = (await PlanService.GetPlan(int.Parse(Id)));
        //Id = Plan.Id.ToString();
        //Plan = (await PlanService.GetPlan(int.Parse(Id)));
    }
    //#region method
    public void NavigateToModulesPlanPage()
    {
        string Id = Plan.Id.ToString();
        NavManager.NavigateTo($"/editplan/{Id}", true);
    }

    //#endregion

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
