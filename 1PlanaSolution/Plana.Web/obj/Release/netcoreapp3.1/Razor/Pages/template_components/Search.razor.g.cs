#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d3d20b4a64837012f8f3042d510eca7f2a11e14"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            __builder.AddMarkupContent(1, @"<form method=""get"">

    <div id=""inputWrapper"">
        <input id=""input"" type=""search"" autocomplete=""off"" placeholder=""Search ..."" asp-for=""SearchTerm "">
        <div id=""cont"">
            <button id=""search-button"">
                <img src=""/images/search.png"" style=""        height: 24px;
        width: 24px; color:aqua"">
            </button>
        </div>

    </div>


</form>


    

");
            __builder.AddMarkupContent(2, @"<style>


    #input {
        background-color: var(--search-box-bg, white);
        border: none;
        border-radius: calc(0.5 * var(--ntp-realbox-height));
        color: var(--search-box-text);
        font-size: 16px;
        height: 100%;
        outline: none;
        padding-inline-end: 40px;
        padding-inline-start: 52px;
        position: relative;
        width: 100%;
        padding: 6px;
        margin-top: 8px;
    }


    #inputWrapper #cont {
        height: 100%;
        left: 330px;
        position: absolute;
        top: 12px;
        border: none;
        border-radius: calc(0.5 * var(--ntp-realbox-height));
    }

        #inputWrapper #cont #search-button {
            border: none;
            color: aqua
        }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
