#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44959686a076737f2651d38fba4a98d713366738"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/sd_navbar")]
    public partial class SdNavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Assignment plan for </h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "topnav");
            __builder.AddAttribute(3, "id", "topnav");
            __builder.AddAttribute(4, "style", "position: relative;top: 0px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "overflow:auto;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "navbar-toggler w3-left");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                      ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<span class=\"navbar-toggler-icon\"><img src=\"/images/toggler.JPG\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "search");
            __builder.AddAttribute(14, "style", "overflow:hidden;height:60px");
            __builder.OpenComponent<Plana.Web.Pages.template_components.Search>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.AddMarkupContent(17, "<div class=\"avatar w3-right\"><a href=\"/myaccount\"><img src=\"/images/avatar.png\" class=\"img-fluid\"></a></div>\r\n        ");
            __builder.AddMarkupContent(18, "<div class=\"logo-image  w3-right\"><a href=\"/home\"><img src=\"/images/logo.png\" class=\"img-fluid\"></a></div>\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "btn-group");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToModulesPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Modules Plan ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToLecturersPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Lecturers Plan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    \r\n   \r\n\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", 
#nullable restore
#line 44 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "style", "width:55%");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "vertical-menu");
            __builder.OpenElement(35, "ul");
            __builder.AddAttribute(36, "class", "nav flex-column");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "/sd_make_new_plan");
            __builder.AddAttribute(42, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 48 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Make new plan\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "/home");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class aria-hidden=\"true\"></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddMarkupContent(54, "<style>\r\n    .topnav {\r\n        position: relative;\r\n        background-color: #f2f2f2;\r\n        /*width: 80%;*/\r\n        letter-spacing: 1px;\r\n        height:100px;\r\n    }\r\n\r\n    .w3-bar {\r\n        width: 100%;\r\n        height: 120px;\r\n        overflow: hidden;\r\n    }\r\n\r\n    .w3-right {\r\n        float: right !important;\r\n    }\r\n\r\n    .w3-left {\r\n        float: left !important;\r\n    }\r\n    /*               sider **/\r\n    .vertical-menu {\r\n        /* width: 200px;*/\r\n        float: left;\r\n        position: sticky;\r\n    }\r\n\r\n\r\n        .vertical-menu a {\r\n            /*  background-color: #eee;*/\r\n            color: black;\r\n            display: block;\r\n            padding: 12px;\r\n            text-decoration: none;\r\n        }\r\n\r\n            /* .vertical-menu a:hover {\r\n                background-color: #ccc;\r\n            }*/\r\n\r\n            .vertical-menu a.active {\r\n                background-color: white;\r\n                color: white;\r\n            }\r\n\r\n    .navbar-toggler-icon {\r\n        width: 46px;\r\n        height: 35px;\r\n        overflow: hidden;\r\n        margin-left: 30px;\r\n        /*  margin-top: -20px;*/\r\n    }\r\n\r\n    .vertical-menu .oi {\r\n        width: 2rem;\r\n        font-size: 1.1rem;\r\n        vertical-align: text-top;\r\n        top: -2px;\r\n    }\r\n\r\n    .vertical-menu .nav-item {\r\n        font-size: 0.9rem;\r\n        padding-bottom: 0.5rem;\r\n    }\r\n\r\n        .vertical-menu .nav-item:first-of-type {\r\n            padding-top: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item:last-of-type {\r\n            padding-bottom: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item a {\r\n            color: #d7d7d7;\r\n            border-radius: 4px;\r\n            height: 3rem;\r\n            display: flex;\r\n            align-items: center;\r\n            line-height: 3rem;\r\n        }\r\n\r\n            .vertical-menu .nav-item a.active {\r\n                /* background-color: rgba(255,255,255,0.25);\r\n                color: white;*/\r\n                color: #FFD700;\r\n            }\r\n\r\n            .vertical-menu .nav-item a:hover {\r\n                background-color: #fff;\r\n                color: #43427d;\r\n            }\r\n\r\n    .search {\r\n        border: none;\r\n        color: rgba(0,0,0,.87);\r\n        display: flex;\r\n        font-size: 16px;\r\n       \r\n    }\r\n    .matList {\r\n\r\n    }\r\n    \r\n    /*button style*/\r\n    .btn-group button {\r\n\r\n        background-color: #f2f2f2; /* Green background */\r\n        border: 1px solid rgb(26, 79, 238); /* Green border */\r\n        color: #333333; /* White text */\r\n        display: flex;\r\n        font-size: 16px;\r\n        font-family: \'ArialMT\', \'Arial\';\r\n        padding: 10px 5px; /* Some padding */\r\n        cursor: pointer; /* Pointer/hand icon */\r\n        float: left; /* Float the buttons side by side */\r\n        border-radius: 12px;\r\n        margin: 4px 8px;\r\n        width: 140px;\r\n        height: 40px;\r\n        position:center;\r\n    }\r\n\r\n        .btn-group button:not(:last-child) {\r\n            border-right: none; /* Prevent double borders */\r\n        }\r\n\r\n    /* Clear floats (clearfix hack) */\r\n    .btn-group:after {\r\n        content: \"\";\r\n        clear: both;\r\n        display: table;\r\n    }\r\n\r\n    /* Add a background color on hover */\r\n    .btn-group button:hover {\r\n        /*background-color:azure;*/\r\n        color:goldenrod;\r\n\r\n    }\r\n\r\n    /*avatar*/\r\n    .avatar {\r\n        width: 94px;\r\n        height: 61px;\r\n        /*border-radius: 50%;*/\r\n        overflow: hidden;\r\n        margin-top: -45px;\r\n        \r\n        /* position: fixed;*/\r\n    }\r\n\r\n   /**  mat select item*/\r\n    .my-item-class {\r\n        width: 100%;\r\n        text-align: center;\r\n    }\r\n\r\n\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
       

    [Inject]
    public NavigationManager navigationManager { get; set; }
    /** nav menu*/
    private bool verticalMenu = true;

    private string openVerticalMenu => verticalMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        verticalMenu = !verticalMenu;
    }
    #region button methods

    protected  void navigateToModulesPlan() {
        navigationManager.NavigateTo("/sd_modulesPlan",true);

    }
    protected void navigateToLecturersPlan()
    {
        navigationManager.NavigateTo("/sd_lecturersPlan", true);

    }
    protected void navigateToMyAccount()
    {
        navigationManager.NavigateTo("/myAccount", true);

    }
    #endregion
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591