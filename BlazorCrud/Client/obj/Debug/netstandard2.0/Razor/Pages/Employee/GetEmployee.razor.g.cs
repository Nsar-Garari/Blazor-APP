#pragma checksum "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff899b55eabe5653e46d442a66f3435992258aff"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Client.Pages.Employee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 3 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client;

#line default
#line hidden
#line 7 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class GetEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Employee Data</h1>\n\n");
            __builder.AddMarkupContent(1, "<p><a href=\"/employee/add\">Create</a></p>");
#line 10 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
 if (empList == null)
{

#line default
#line hidden
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#line 13 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
}
else
{

#line default
#line hidden
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\n                <th>Name</th>\n                <th>Designation</th>\n                <th>Email</th>\n                <th>Location</th>\n                <th>Phone</th>\n                <th>Action</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#line 29 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
             foreach (var emp in empList)
            {

#line default
#line hidden
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#line 32 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.EmployeeId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#line 33 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 34 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.Designation

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#line 35 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.Email

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 36 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.Location

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 37 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                         emp.PhoneNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/employee/edit/" + (
#line 39 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                                                 emp.EmployeeId

#line default
#line hidden
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "  |\n                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/employee/delete/" + (
#line 40 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
                                                   emp.EmployeeId

#line default
#line hidden
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#line 43 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
            }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
#line 46 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 48 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\GetEmployee.razor"
       
    Employee[] empList;

    protected override async Task OnInitializedAsync()
    {
        empList = await Http.GetJsonAsync<Employee[]>("/api/Employee/Index");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
