#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3936753cf0845b2eaef401970c8847f78bf48e2"
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
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "overflow:auto;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "navbar-toggler w3-left");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                      ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<span class=\"navbar-toggler-icon\">\r\n                <img src=\"/images/toggler.JPG\">\r\n            </span>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "search");
            __builder.AddAttribute(17, "style", "overflow:hidden;height:60px");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<Plana.Web.Pages.template_components.Search>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "selectYear");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenComponent<Plana.Web.Pages.template_components.CustomSelect>(25);
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<div class=\"avatar w3-right\">\r\n            <a href=\"/myaccount\">\r\n                <img src=\"/images/avatar.png\" class=\"img-fluid\">\r\n            </a>\r\n        </div>\r\n        ");
            __builder.AddMarkupContent(29, "<div class=\"logo-image  w3-right\">\r\n            <a href=\"/home\">\r\n                <img src=\"/images/logo.png\" class=\"img-fluid\">\r\n            </a>\r\n\r\n\r\n        </div>\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "btn-group");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToModulesPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Modules Plan ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToLecturersPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Lecturers Plan");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    \r\n   \r\n\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", 
#nullable restore
#line 46 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "style", "width:55%");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "vertical-menu");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "ul");
            __builder.AddAttribute(52, "class", "nav flex-column");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "nav-item px-3");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", "nav-link");
            __builder.AddAttribute(59, "href", "/sd_make_new_plan");
            __builder.AddAttribute(60, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 50 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Make new plan\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "nav-item px-3");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "nav-link");
            __builder.AddAttribute(70, "href", "/home");
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, "\r\n                        <span class aria-hidden=\"true\"></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.AddMarkupContent(79, "<style>\r\n    .topnav {\r\n        position: relative;\r\n        background-color: #f2f2f2;\r\n        /*width: 80%;*/\r\n        letter-spacing: 1px;\r\n        height:100px;\r\n    }\r\n\r\n    .w3-bar {\r\n        width: 100%;\r\n        height: 120px;\r\n        overflow: hidden;\r\n    }\r\n\r\n    .w3-right {\r\n        float: right !important;\r\n    }\r\n\r\n    .w3-left {\r\n        float: left !important;\r\n    }\r\n    /*               sider **/\r\n    .vertical-menu {\r\n        /* width: 200px;*/\r\n        float: left;\r\n        position: sticky;\r\n    }\r\n\r\n\r\n        .vertical-menu a {\r\n            /*  background-color: #eee;*/\r\n            color: black;\r\n            display: block;\r\n            padding: 12px;\r\n            text-decoration: none;\r\n        }\r\n\r\n            /* .vertical-menu a:hover {\r\n                background-color: #ccc;\r\n            }*/\r\n\r\n            .vertical-menu a.active {\r\n                background-color: white;\r\n                color: white;\r\n            }\r\n\r\n    .navbar-toggler-icon {\r\n        width: 46px;\r\n        height: 35px;\r\n        overflow: hidden;\r\n        margin-left: 30px;\r\n        /*  margin-top: -20px;*/\r\n    }\r\n\r\n    .vertical-menu .oi {\r\n        width: 2rem;\r\n        font-size: 1.1rem;\r\n        vertical-align: text-top;\r\n        top: -2px;\r\n    }\r\n\r\n    .vertical-menu .nav-item {\r\n        font-size: 0.9rem;\r\n        padding-bottom: 0.5rem;\r\n    }\r\n\r\n        .vertical-menu .nav-item:first-of-type {\r\n            padding-top: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item:last-of-type {\r\n            padding-bottom: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item a {\r\n            color: #d7d7d7;\r\n            border-radius: 4px;\r\n            height: 3rem;\r\n            display: flex;\r\n            align-items: center;\r\n            line-height: 3rem;\r\n        }\r\n\r\n            .vertical-menu .nav-item a.active {\r\n                /* background-color: rgba(255,255,255,0.25);\r\n                color: white;*/\r\n                color: #FFD700;\r\n            }\r\n\r\n            .vertical-menu .nav-item a:hover {\r\n                background-color: #fff;\r\n                color: #43427d;\r\n            }\r\n\r\n    .search {\r\n        border: none;\r\n        color: rgba(0,0,0,.87);\r\n        display: flex;\r\n        font-size: 16px;\r\n       \r\n    }\r\n    \r\n    .matList {\r\n\r\n    }\r\n    \r\n    /*button style*/\r\n    .btn-group button {\r\n\r\n        background-color: #f2f2f2; /* Green background */\r\n        border: 1px solid rgb(26, 79, 238); /* Green border */\r\n        color: #333333; /* White text */\r\n        display: flex;\r\n        font-size: 16px;\r\n        font-family: \'ArialMT\', \'Arial\';\r\n        padding: 10px 5px; /* Some padding */\r\n        cursor: pointer; /* Pointer/hand icon */\r\n        float: left; /* Float the buttons side by side */\r\n        border-radius: 12px;\r\n        margin: 4px 8px;\r\n        width: 140px;\r\n        height: 40px;\r\n        position:center;\r\n    }\r\n\r\n        .btn-group button:not(:last-child) {\r\n            border-right: none; /* Prevent double borders */\r\n        }\r\n\r\n    /* Clear floats (clearfix hack) */\r\n    .btn-group:after {\r\n        content: \"\";\r\n        clear: both;\r\n        display: table;\r\n    }\r\n\r\n    /* Add a background color on hover */\r\n    .btn-group button:hover {\r\n        /*background-color:azure;*/\r\n        color:goldenrod;\r\n\r\n    }\r\n\r\n    /*avatar*/\r\n    .avatar {\r\n        width: 94px;\r\n        height: 61px;\r\n        /*border-radius: 50%;*/\r\n        overflow: hidden;\r\n        margin-top: -45px;\r\n        \r\n        /* position: fixed;*/\r\n    }\r\n\r\n   /**  mat select item*/\r\n    .my-item-class {\r\n        width: 100%;\r\n        text-align: center;\r\n    }\r\n    /** dropdown select*/\r\n    .selectYear {\r\n    \r\n        border-width: 0px;\r\n        position: absolute;\r\n        left: 399px;\r\n        top: 41px;\r\n        width: 177px;\r\n        height: 37px;\r\n        display: flex;\r\n        color: #000000;\r\n        text-align: left;\r\n    }\r\n\r\n\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
       

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
