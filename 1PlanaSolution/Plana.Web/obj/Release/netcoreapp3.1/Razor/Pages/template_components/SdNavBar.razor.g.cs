#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64fa277a6826b7ace9121d46a981ae6ddccc530d"
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
#line 2 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
using Plana.Web.Pages.plan.study_director;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sd_navbar")]
    public partial class SdNavBar : EditPlanBase
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
#line 12 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
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
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "selectYear");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenComponent<Plana.Web.Pages.template_components.CustomSelect>(25);
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
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
#line 38 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
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
#line 39 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToLecturersPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Lecturers Plan");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                e=>OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Make new Plan");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(47);
            __builder.AddAttribute(48, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                           e=>OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "Add Employee");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n    <hr>\r\n    ");
            __builder.OpenComponent<MatBlazor.MatDialog>(53);
            __builder.AddAttribute(54, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                             dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(58);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(60, "Add Plan");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(62);
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n            {\r\n            ");
                    __Blazor.Plana.Web.Pages.template_components.SdNavBar.TypeInference.CreateMatTextField_0(__builder3, 65, 66, "Plan Year", 67, 
#nullable restore
#line 52 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                          planNew.Year

#line default
#line hidden
#nullable disable
                    , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => planNew.Year = __value, planNew.Year)), 69, () => planNew.Year);
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __Blazor.Plana.Web.Pages.template_components.SdNavBar.TypeInference.CreateMatTextField_1(__builder3, 71, 72, "Plan isFixed", 73, 
#nullable restore
#line 53 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                             planNew.IsFixed

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => planNew.IsFixed = __value, planNew.IsFixed)), 75, () => planNew.IsFixed);
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __Blazor.Plana.Web.Pages.template_components.SdNavBar.TypeInference.CreateMatTextField_2(__builder3, 77, 78, "Autumn Semester", 79, 
#nullable restore
#line 54 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                planNew.AutumnSemester.Code

#line default
#line hidden
#nullable disable
                    , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => planNew.AutumnSemester.Code = __value, planNew.AutumnSemester.Code)), 81, () => planNew.AutumnSemester.Code);
                    __builder3.AddMarkupContent(82, "\r\n            ");
                    __Blazor.Plana.Web.Pages.template_components.SdNavBar.TypeInference.CreateMatTextField_3(__builder3, 83, 84, "Spring Semester", 85, 
#nullable restore
#line 55 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                planNew.SpringSemester.Code

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => planNew.SpringSemester.Code = __value, planNew.SpringSemester.Code)), 87, () => planNew.SpringSemester.Code);
                    __builder3.AddMarkupContent(88, "\r\n            }\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(90);
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(92, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(93);
                    __builder3.AddAttribute(94, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                okClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(96, "Add");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(98);
                    __builder3.AddAttribute(99, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                CloseDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(101, "Close");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n    \r\n\r\n\r\n    ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", 
#nullable restore
#line 67 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(107, "style", "width:55%");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "vertical-menu");
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.OpenElement(113, "ul");
            __builder.AddAttribute(114, "class", "nav flex-column");
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.OpenElement(116, "li");
            __builder.AddAttribute(117, "class", "nav-item px-3");
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(119);
            __builder.AddAttribute(120, "class", "nav-link");
            __builder.AddAttribute(121, "href", "/sd_NewPlan");
            __builder.AddAttribute(122, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 71 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(124, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Make new plan\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.OpenElement(127, "li");
            __builder.AddAttribute(128, "class", "nav-item px-3");
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(130);
            __builder.AddAttribute(131, "class", "nav-link");
            __builder.AddAttribute(132, "href", "/home");
            __builder.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(134, "\r\n                        <span class aria-hidden=\"true\"></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
            __builder.AddMarkupContent(141, "<style>\r\n    .topnav {\r\n        position: relative;\r\n        background-color: #f2f2f2;\r\n        /*width: 80%;*/\r\n        letter-spacing: 1px;\r\n        height: 100px;\r\n    }\r\n\r\n    .w3-bar {\r\n        width: 100%;\r\n        height: 120px;\r\n        overflow: hidden;\r\n    }\r\n\r\n    .w3-right {\r\n        float: right !important;\r\n    }\r\n\r\n    .w3-left {\r\n        float: left !important;\r\n    }\r\n    /*               sider **/\r\n    .vertical-menu {\r\n        /* width: 200px;*/\r\n        float: left;\r\n        position: sticky;\r\n    }\r\n\r\n\r\n        .vertical-menu a {\r\n            /*  background-color: #eee;*/\r\n            color: black;\r\n            display: block;\r\n            padding: 12px;\r\n            text-decoration: none;\r\n        }\r\n\r\n            /* .vertical-menu a:hover {\r\n                background-color: #ccc;\r\n            }*/\r\n\r\n            .vertical-menu a.active {\r\n                background-color: white;\r\n                color: white;\r\n            }\r\n\r\n    .navbar-toggler-icon {\r\n        width: 46px;\r\n        height: 35px;\r\n        overflow: hidden;\r\n        margin-left: 30px;\r\n        /*  margin-top: -20px;*/\r\n    }\r\n\r\n    .vertical-menu .oi {\r\n        width: 2rem;\r\n        font-size: 1.1rem;\r\n        vertical-align: text-top;\r\n        top: -2px;\r\n    }\r\n\r\n    .vertical-menu .nav-item {\r\n        font-size: 0.9rem;\r\n        padding-bottom: 0.5rem;\r\n    }\r\n\r\n        .vertical-menu .nav-item:first-of-type {\r\n            padding-top: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item:last-of-type {\r\n            padding-bottom: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item a {\r\n            color: #d7d7d7;\r\n            border-radius: 4px;\r\n            height: 3rem;\r\n            display: flex;\r\n            align-items: center;\r\n            line-height: 3rem;\r\n        }\r\n\r\n            .vertical-menu .nav-item a.active {\r\n                /* background-color: rgba(255,255,255,0.25);\r\n                color: white;*/\r\n                color: #FFD700;\r\n            }\r\n\r\n            .vertical-menu .nav-item a:hover {\r\n                background-color: #fff;\r\n                color: #43427d;\r\n            }\r\n\r\n    .search {\r\n        border: none;\r\n        color: rgba(0,0,0,.87);\r\n        display: flex;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .matList {\r\n    }\r\n\r\n    /*button style*/\r\n    .btn-group button {\r\n        background-color: #f2f2f2; /* Green background */\r\n        border: 1px solid rgb(26, 79, 238); /* Green border */\r\n        color: #333333; /* White text */\r\n        display: flex;\r\n        font-size: 16px;\r\n        font-family: \'ArialMT\', \'Arial\';\r\n        padding: 10px 5px; /* Some padding */\r\n        cursor: pointer; /* Pointer/hand icon */\r\n        float: left; /* Float the buttons side by side */\r\n        border-radius: 12px;\r\n        margin: 4px 8px;\r\n        width: 140px;\r\n        height: 40px;\r\n        position: center;\r\n    }\r\n\r\n        .btn-group button:not(:last-child) {\r\n            border-right: none; /* Prevent double borders */\r\n        }\r\n\r\n    /* Clear floats (clearfix hack) */\r\n    .btn-group:after {\r\n        content: \"\";\r\n        clear: both;\r\n        display: table;\r\n    }\r\n\r\n    /* Add a background color on hover */\r\n    .btn-group button:hover {\r\n        /*background-color:azure;*/\r\n        color: goldenrod;\r\n    }\r\n\r\n    /*avatar*/\r\n    .avatar {\r\n        width: 94px;\r\n        height: 61px;\r\n        /*border-radius: 50%;*/\r\n        overflow: hidden;\r\n        margin-top: -45px;\r\n        /* position: fixed;*/\r\n    }\r\n\r\n    /**  mat select item*/\r\n    .my-item-class {\r\n        width: 100%;\r\n        text-align: center;\r\n    }\r\n    /** dropdown select*/\r\n    .selectYear {\r\n        border-width: 0px;\r\n        position: absolute;\r\n        left: 399px;\r\n        top: 41px;\r\n        width: 177px;\r\n        height: 37px;\r\n        display: flex;\r\n        color: #000000;\r\n        text-align: left;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
       

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

    protected void navigateToModulesPlan()
    {
        navigationManager.NavigateTo("/sd_modulesPlan", true);

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

    /** make new plan*/
    public IPlanService TPlanService { get; set; }

    Plan planNew = new Plan();
    Plan selectedPlan = null;
    Plan tempPlan = null;
    bool dialogIsOpen = false;
    bool _isEdit = false;

    bool snackBar = false;
    //List<Plan> Plans = PlanService.GetPlans().ToList();










    #region Methods

    #endregion

    #region Dialog Box Methods
    private void OpenDialog(bool isEdit)
    {
        _isEdit = isEdit;
        //if (!_isEdit) plan = new Plan();
        dialogIsOpen = true;
    }
    private async void okClick()
    {
        dialogIsOpen = false;
        await this.HandleValidSubmit();
    }
    private void CloseDialog()
    {
        dialogIsOpen = false;
        if (selectedPlan != null)
        {
            planNew = selectedPlan;
            
        }
    }
    #endregion



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Plana.Web.Pages.template_components.SdNavBar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
