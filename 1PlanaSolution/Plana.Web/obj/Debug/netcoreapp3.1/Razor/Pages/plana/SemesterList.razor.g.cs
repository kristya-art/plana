#pragma checksum "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plana\SemesterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7585b357d0870331df0ecca6f3f843eb103520b5"
// <auto-generated/>
#pragma warning disable 1591
namespace Plana.Web.Pages.plana
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
#line 2 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plana\SemesterList.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/semester")]
    public partial class SemesterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Add");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Code\PLANA\planning-of-the-assignments-for-lecturers-plana\1PlanaSolution\Plana.Web\Pages\plana\SemesterList.razor"
       
    //Employee employee = new Employee();
    //Employee selectedEmp = null;
    //Employee tempEmp = null;
    //int _index = -1;


    //public class Employee
    //{
    //    public int EmployeeId { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public DateTime JoiningDate { get; set; }
    //    public int YearOfExperience { get; set; }

    //    List<Employee> employees = new List<Employee>()
    //    {
    //        new Employee (1, "Marco"),
    //        new Employee(2, "May")
    //};

    //    #region Constructors
    //    public Employee() { }
    //    public Employee(int EmployeeId,string name)
    //    {
    //        EmployeeId = EmployeeId;
    //        Name = name;
    //    }
    //    #endregion
    //    #region Methods
    //    private void AddEmployee(Employee emp)
    //    {
    //        emp.EmployeeId = employees.Count + 1;
    //        employees.Add(emp);
    //    }
    //    private void EditEmployee(Employee emp)
    //    {
    //        if (emp != null && emp.EmployeeId > 0)
    //        {
    //            int index = employees.FindIndex(a => a.EmployeeId == emp.EmployeeId);
    //            employees.RemoveAll(x => x.EmployeeId == emp.EmployeeId);
    //            employees.Insert(index, emp);

    //        }
    //    }



    //    #endregion
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591