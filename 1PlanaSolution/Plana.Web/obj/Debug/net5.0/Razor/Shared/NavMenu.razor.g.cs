#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa88fbb941c0f1d058c0f6b230199049be7eab2"
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
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "overflow:auto;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "navbar-toggler w3-left");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                      ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "<span class=\"navbar-toggler-icon\"><img src=\"/images/toggler.JPG\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n      \r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "search");
            __builder.AddAttribute(13, "style", "overflow:hidden;height:60px;");
            __builder.OpenComponent<Plana.Web.Pages.template_components.Search>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<div class=\"avaLogo\"><div class=\"avatar w3-right\"><a href=\"/myaccount\"><img src=\"/images/avatar.png\" class=\"img-fluid\"></a></div>\r\n            <div class=\"logo-image  w3-right\"><a href=\"/home\"><img src=\"/images/logo.png\" class=\"img-fluid\"></a></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    \r\n    \r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", 
#nullable restore
#line 33 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                 openVerticalMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "style", "width:55%");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "vertical-menu");
            __builder.OpenElement(24, "ul");
            __builder.AddAttribute(25, "class", "nav flex-column");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(26);
            __builder.AddAttribute(27, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
                __builder2.AddAttribute(31, "class", "nav-link");
                __builder2.AddAttribute(32, "href", "/sd_NewPlan");
                __builder2.AddAttribute(33, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 39 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(35, "<span class=\"oi oi-file\" aria-hidden=\"true\"></span> Planning\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "li");
                __builder2.AddAttribute(38, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
                __builder2.AddAttribute(40, "class", "nav-link");
                __builder2.AddAttribute(41, "href", "/lecturers");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "<span class=\"oi oi-file\" aria-hidden=\"true\"></span> Lecturers\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "li");
                __builder2.AddAttribute(46, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
                __builder2.AddAttribute(48, "class", "nav-link");
                __builder2.AddAttribute(49, "href", "/editlecturer");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "<span class=\"oi oi-file\" aria-hidden=\"true\"></span> Create Lecturer\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "li");
                __builder2.AddAttribute(54, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
                __builder2.AddAttribute(56, "class", "nav-link");
                __builder2.AddAttribute(57, "href", "/lecturergroupsview");
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "<span class=\"oi oi-file\" aria-hidden=\"true\"></span> Lecturers Groups\r\n                         ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n\r\n\r\n                        ");
                __builder2.OpenElement(61, "li");
                __builder2.AddAttribute(62, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
                __builder2.AddAttribute(64, "class", "nav-link");
                __builder2.AddAttribute(65, "href", "/home");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "<span class aria-hidden=\"true\"></span> Home\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n                        ");
                __builder2.OpenElement(69, "li");
                __builder2.AddAttribute(70, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
                __builder2.AddAttribute(72, "class", "nav-link");
                __builder2.AddAttribute(73, "href", "/identity/account/login");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "<span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "li");
                __builder2.AddAttribute(78, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(79);
                __builder2.AddAttribute(80, "class", "nav-link");
                __builder2.AddAttribute(81, "href", "/identity/account/logout");
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(83, "<span class=\"oi oi-power-standby\" aria-hidden=\"true\"></span> Logout\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(84, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(85, "li");
                __builder2.AddAttribute(86, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
                __builder2.AddAttribute(88, "class", "nav-link");
                __builder2.AddAttribute(89, "href", "/identity/account/login");
                __builder2.AddAttribute(90, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 85 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
                                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(92, "<span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(94, @"<style>
    .topnav {
        position: relative;
        background-color: #f2f2f2;
        /*width: 80%;*/
        letter-spacing: 1px;
        height: 100px;
    }

    .w3-bar {
        width: 100%;
        height: 120px;
        overflow: hidden;
    }

    .w3-right {
        float: right !important;
    }

    .w3-left {
        float: left !important;
    }
    
    

    .navbar-toggler-icon {
        width: 46px;
        height: 35px;
        overflow: hidden;
        margin-left: 30px;
      
    }

    

    .search {
        border: none;
        color: rgba(0,0,0,.87);
        display: flex;
        font-size: 16px;
    }

    .matList {
    }

    

    /**  mat select item*/
    .my-item-class {
        width: 100%;
        text-align: center;
    }
    
    .avaLogo {
        float: right;
        padding: 10px 5px;
        margin: 4px 8px;
        margin-top: -45px;
    }

    .logo-image {
        width: 75px;
        height: 59px;
        left: 0;
        overflow: hidden;
    }

    /*avatar*/
    .avatar {
        width: 94px;
        height: 61px;
    }
    
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Shared\NavMenu.razor"
       

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

    



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591