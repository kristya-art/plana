#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f83da95696086c9c0ade8a4180fa369e2494b8"
// <auto-generated/>
#pragma warning disable 1591
namespace Plana.Web.Pages.lecturer
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
    public partial class DisplayLecturer : DisplayLecturerBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width: 30.5%;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                 Lecturer.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                                     Lecturer.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(12, "style", "width:165px;height:165px");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 8 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                                                                                        Lecturer.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
         if (ShowFooter)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-footer text-center");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", 
#nullable restore
#line 13 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                   $"lecturerdetails/{Lecturer.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "btn btn-primary m-1");
            __builder.AddContent(19, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 16 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                   $"editlecturer/{Lecturer.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "btn btn-primary m-1");
            __builder.AddContent(24, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 17 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                   $"startL/{Lecturer.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn btn-primary m-1");
            __builder.AddContent(29, "Go to my Plan");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", " btn btn-danger ");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
                                                                 Soft_delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\lecturer\DisplayLecturer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
