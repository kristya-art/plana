// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 408 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plan\study_director\EditPlan.razor"
       
    
        #region variables


        #endregion


        /// <summary>
            /// js code for button
            ///
      ///  </summary>

        protected override async void OnAfterRender(bool firstRender)
        {
        await js.InvokeVoidAsync("renderjQueryComponents");
        base.OnAfterRender(firstRender);

        }

        private async Task CallJSMethod()
        {

        //await JS.InvokeVoidAsync("CollapseTableRow");
        await js.InvokeVoidAsync("GetName");

        }
        private async Task CallJSMethod2()
        {
        await js.InvokeVoidAsync("SetButtonsVisible");
        }

        public void EditEvent()
        {

        }

        #region Last Year Plan

        #endregion
        #region Dialog Box Methods for Last Year Plan
        bool _isDelete = false;
        bool dialogIsOpen = false;
        bool _isEdit = false;
        private void OpenDialog(bool isEdit)
        {

        //if (!_isEdit) plan = new Plan();
        dialogIsOpen = true;
        }
        private void okCklick()
        {
        dialogIsOpen = false;

        }
        private void CloseDialog()
        {
        dialogIsOpen = false;

        }
        #endregion
        #region New Module
        bool moduledialogIsOpen = false;
        private void OpenModuleDialog(bool isEdit)
        {
        moduledialogIsOpen = true;
        }

        private void moduleOkClick()
        {
        moduledialogIsOpen = false;
        }
        private async Task CreateModule()
        {


        await AddNewModule();
        moduledialogIsOpen = false;
        }
        #endregion


        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
