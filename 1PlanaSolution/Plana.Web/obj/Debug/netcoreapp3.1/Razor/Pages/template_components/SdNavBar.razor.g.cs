#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea56814fe0a529690f7a4ccc5b6297fb9683e036"
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
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "matList");
            __builder.AddAttribute(24, "style", "overflow:hidden;height:60px");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenComponent<MatBlazor.MatList>(26);
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "p");
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __Blazor.Plana.Web.Pages.template_components.SdNavBar.TypeInference.CreateMatSelectItem_0(__builder2, 31, 32, "my-item-class", 33, 
#nullable restore
#line 22 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                                       year_values

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 22 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                       value1

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value1 = __value, value1)), 36, () => value1);
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n        ");
            __builder.AddMarkupContent(41, "<div class=\"avatar w3-right\">\r\n            <a href=\"/myaccount\">\r\n                <img src=\"/images/avatar.png\" class=\"img-fluid\">\r\n            </a>\r\n        </div>\r\n        ");
            __builder.AddMarkupContent(42, "<div class=\"logo-image  w3-right\">\r\n            <a href=\"/home\">\r\n                <img src=\"/images/logo.png\" class=\"img-fluid\">\r\n            </a>\r\n\r\n\r\n        </div>\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "btn-group");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToModulesPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Modules Plan ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                               navigateToLecturersPlan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Lecturers Plan");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    \r\n   \r\n\r\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", 
#nullable restore
#line 54 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "style", "width:55%");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "vertical-menu");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "ul");
            __builder.AddAttribute(65, "class", "nav flex-column");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "li");
            __builder.AddAttribute(68, "class", "nav-item px-3");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
            __builder.AddAttribute(71, "class", "nav-link");
            __builder.AddAttribute(72, "href", "/sd_make_new_plan");
            __builder.AddAttribute(73, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 58 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Make new plan\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "class", "nav-item px-3");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "class", "nav-link");
            __builder.AddAttribute(83, "href", "/home");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n                        <span class aria-hidden=\"true\"></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
            __builder.AddMarkupContent(92, "<style>\r\n    .topnav {\r\n        position: relative;\r\n        background-color: #f2f2f2;\r\n        /*width: 80%;*/\r\n        letter-spacing: 1px;\r\n        height:100px;\r\n    }\r\n\r\n    .w3-bar {\r\n        width: 100%;\r\n        height: 120px;\r\n        overflow: hidden;\r\n    }\r\n\r\n    .w3-right {\r\n        float: right !important;\r\n    }\r\n\r\n    .w3-left {\r\n        float: left !important;\r\n    }\r\n    /*               sider **/\r\n    .vertical-menu {\r\n        /* width: 200px;*/\r\n        float: left;\r\n        position: sticky;\r\n    }\r\n\r\n\r\n        .vertical-menu a {\r\n            /*  background-color: #eee;*/\r\n            color: black;\r\n            display: block;\r\n            padding: 12px;\r\n            text-decoration: none;\r\n        }\r\n\r\n            /* .vertical-menu a:hover {\r\n                background-color: #ccc;\r\n            }*/\r\n\r\n            .vertical-menu a.active {\r\n                background-color: white;\r\n                color: white;\r\n            }\r\n\r\n    .navbar-toggler-icon {\r\n        width: 46px;\r\n        height: 35px;\r\n        overflow: hidden;\r\n        margin-left: 30px;\r\n        /*  margin-top: -20px;*/\r\n    }\r\n\r\n    .vertical-menu .oi {\r\n        width: 2rem;\r\n        font-size: 1.1rem;\r\n        vertical-align: text-top;\r\n        top: -2px;\r\n    }\r\n\r\n    .vertical-menu .nav-item {\r\n        font-size: 0.9rem;\r\n        padding-bottom: 0.5rem;\r\n    }\r\n\r\n        .vertical-menu .nav-item:first-of-type {\r\n            padding-top: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item:last-of-type {\r\n            padding-bottom: 1rem;\r\n        }\r\n\r\n        .vertical-menu .nav-item a {\r\n            color: #d7d7d7;\r\n            border-radius: 4px;\r\n            height: 3rem;\r\n            display: flex;\r\n            align-items: center;\r\n            line-height: 3rem;\r\n        }\r\n\r\n            .vertical-menu .nav-item a.active {\r\n                /* background-color: rgba(255,255,255,0.25);\r\n                color: white;*/\r\n                color: #FFD700;\r\n            }\r\n\r\n            .vertical-menu .nav-item a:hover {\r\n                background-color: #fff;\r\n                color: #43427d;\r\n            }\r\n\r\n    .search {\r\n        border: none;\r\n        color: rgba(0,0,0,.87);\r\n        display: flex;\r\n        font-size: 16px;\r\n       \r\n    }\r\n    .matList {\r\n\r\n    }\r\n    \r\n    /*button style*/\r\n    .btn-group button {\r\n\r\n        background-color: #f2f2f2; /* Green background */\r\n        border: 1px solid rgb(26, 79, 238); /* Green border */\r\n        color: #333333; /* White text */\r\n        display: flex;\r\n        font-size: 16px;\r\n        font-family: \'ArialMT\', \'Arial\';\r\n        padding: 10px 5px; /* Some padding */\r\n        cursor: pointer; /* Pointer/hand icon */\r\n        float: left; /* Float the buttons side by side */\r\n        border-radius: 12px;\r\n        margin: 4px 8px;\r\n        width: 140px;\r\n        height: 40px;\r\n        position:center;\r\n    }\r\n\r\n        .btn-group button:not(:last-child) {\r\n            border-right: none; /* Prevent double borders */\r\n        }\r\n\r\n    /* Clear floats (clearfix hack) */\r\n    .btn-group:after {\r\n        content: \"\";\r\n        clear: both;\r\n        display: table;\r\n    }\r\n\r\n    /* Add a background color on hover */\r\n    .btn-group button:hover {\r\n        /*background-color:azure;*/\r\n        color:goldenrod;\r\n\r\n    }\r\n\r\n    /*avatar*/\r\n    .avatar {\r\n        width: 94px;\r\n        height: 61px;\r\n        /*border-radius: 50%;*/\r\n        overflow: hidden;\r\n        margin-top: -45px;\r\n        \r\n        /* position: fixed;*/\r\n    }\r\n\r\n   /**  mat select item*/\r\n    .my-item-class {\r\n        width: 100%;\r\n        text-align: center;\r\n    }\r\n\r\n\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\template_components\SdNavBar.razor"
       

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
    #region mat select item
    string value1 = "2020-2021";

    string[] year_values = new[]
    {
      "2020-2021",
      "2021-2022",
      "2022-2023",
    };
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
        public static void CreateMatSelectItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IReadOnlyList<TValue> __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
