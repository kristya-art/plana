#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3acc685ece1070e53eed4e083e2477d31d43a3"
// <auto-generated/>
#pragma warning disable 1591
namespace Plana.Web.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "topnav");
            __builder.AddAttribute(2, "id", "topnav");
            __builder.AddAttribute(3, "style", "position: relative;top: 0px;");
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "overflow:auto;");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "navbar-toggler w3-left");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                      ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<span class=\"navbar-toggler-icon\">\r\n                <img src=\"/images/toggler.JPG\">\r\n            </span>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n      \r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "search");
            __builder.AddAttribute(16, "style", "overflow:hidden;height:60px;");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenComponent<Plana.Web.Pages.template_components.Search>(18);
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, @"<div class=""avaLogo"">
            <div class=""avatar w3-right"">
                <a href=""/myaccount"">
                <img src=""/images/avatar.png"" class=""img-fluid"">
                </a>
            </div>
            <div class=""logo-image  w3-right"">
                <a href=""/home"">
                <img src=""/images/logo.png"" class=""img-fluid"">
                </a>
            </div>
        </div>

    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    \r\n    \r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", 
#nullable restore
#line 33 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "style", "width:55%");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "vertical-menu");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "nav flex-column");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(34);
            __builder.AddAttribute(35, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "li");
                __builder2.AddAttribute(38, "class", "nav-item px-3");
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
                __builder2.AddAttribute(41, "class", "nav-link");
                __builder2.AddAttribute(42, "href", "/sd_NewPlan");
                __builder2.AddAttribute(43, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 39 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n                                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Make new plan\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "href", "/home");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "\r\n                                <span class aria-hidden=\"true\"></span> Home\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.OpenElement(58, "li");
                __builder2.AddAttribute(59, "class", "nav-item px-3");
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
                __builder2.AddAttribute(62, "class", "nav-link");
                __builder2.AddAttribute(63, "href", "/identity/account/login");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n                                <span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.OpenElement(68, "li");
                __builder2.AddAttribute(69, "class", "nav-item px-3");
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
                __builder2.AddAttribute(72, "class", "nav-link");
                __builder2.AddAttribute(73, "href", "/identity/account/logout");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n                                <span class=\"oi oi-power-standby\" aria-hidden=\"true\"></span> Logout\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                    ");
            }
            ));
            __builder.AddAttribute(78, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenElement(80, "li");
                __builder2.AddAttribute(81, "class", "nav-item px-3");
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
                __builder2.AddAttribute(84, "class", "nav-link");
                __builder2.AddAttribute(85, "href", "/identity/account/login");
                __builder2.AddAttribute(86, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 61 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(88, "\r\n                                <span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(96, "<style>\r\n    .topnav {\r\n        position: relative;\r\n        background-color: #f2f2f2;\r\n        /*width: 80%;*/\r\n        letter-spacing: 1px;\r\n        height: 100px;\r\n    }\r\n\r\n    .w3-bar {\r\n        width: 100%;\r\n        height: 120px;\r\n        overflow: hidden;\r\n    }\r\n\r\n    .w3-right {\r\n        float: right !important;\r\n    }\r\n\r\n    .w3-left {\r\n        float: left !important;\r\n    }\r\n    \r\n    \r\n\r\n    .navbar-toggler-icon {\r\n        width: 46px;\r\n        height: 35px;\r\n        overflow: hidden;\r\n        margin-left: 30px;\r\n      \r\n    }\r\n\r\n    \r\n\r\n    .search {\r\n        border: none;\r\n        color: rgba(0,0,0,.87);\r\n        display: flex;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .matList {\r\n    }\r\n\r\n    /*button style*/\r\n    .btn-group button {\r\n        background-color: #f2f2f2; /* Green background */\r\n        border: 1px solid rgb(26, 79, 238); /* Green border */\r\n        color: #333333; /* White text */\r\n        display: flex;\r\n        font-size: 16px;\r\n        font-family: \'ArialMT\', \'Arial\';\r\n        padding: 10px 5px; /* Some padding */\r\n        cursor: pointer; /* Pointer/hand icon */\r\n        float: left; /* Float the buttons side by side */\r\n        border-radius: 12px;\r\n        margin: 4px 8px;\r\n        width: 140px;\r\n        height: 40px;\r\n        position: center;\r\n    }\r\n\r\n        .btn-group button:not(:last-child) {\r\n            border-right: none; /* Prevent double borders */\r\n        }\r\n\r\n    /* Clear floats (clearfix hack) */\r\n    .btn-group:after {\r\n        content: \"\";\r\n        clear: both;\r\n        display: table;\r\n    }\r\n\r\n    /* Add a background color on hover */\r\n    .btn-group button:hover {\r\n        /*background-color:azure;*/\r\n        color: goldenrod;\r\n    }\r\n\r\n\r\n\r\n    /**  mat select item*/\r\n    .my-item-class {\r\n        width: 100%;\r\n        text-align: center;\r\n    }\r\n    /** dropdown select*/\r\n  /*  .selectYear {\r\n        border-width: 0px;\r\n        position: absolute;\r\n        left: 500px;\r\n        top: 41px;\r\n        width: 177px;\r\n        height: 37px;\r\n        display: flex;\r\n        color: #000000;\r\n        text-align: left;\r\n    }*/\r\n    \r\n\r\n    .avaLogo {\r\n        float: right;\r\n        padding: 10px 5px;\r\n        margin: 4px 8px;\r\n        margin-top: -45px;\r\n    }\r\n\r\n    .logo-image {\r\n        width: 75px;\r\n        height: 59px;\r\n        left: 0;\r\n        overflow: hidden;\r\n    }\r\n\r\n    /*avatar*/\r\n    .avatar {\r\n        width: 94px;\r\n        height: 61px;\r\n    }\r\n    \r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
       

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

   
    protected void navigateToMyAccount()
    {
        navigationManager.NavigateTo("/myAccount", true);

    }
    #endregion

   

    bool snackBar = false;
    //List<Plan> Plans = PlanService.GetPlans().ToList();










    #region Methods

    #endregion

    #region Dialog Box Methods
    
    #endregion



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
