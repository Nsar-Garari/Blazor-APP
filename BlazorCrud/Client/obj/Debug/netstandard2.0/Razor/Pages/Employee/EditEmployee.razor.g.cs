#pragma checksum "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e848d8b48ca885cfc4533640be4180ef7bfc20"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/edit/{empID}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit</h2>\n");
            __builder.AddMarkupContent(1, "<h4>Employees</h4>\n<hr>\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.OpenElement(6, "form");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "for", "Name");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 13 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                               emp.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Name = __value, emp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "<label asp-for=\"Designation\" class=\"control-label\">Designation</label>\n                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "for", "Designation");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                                      emp.Designation

#line default
#line hidden
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Designation = __value, emp.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label asp-for=\"Email\" class=\"control-label\">Email</label>\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "asp-for", "Email");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 21 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                                    emp.Email

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Email = __value, emp.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "<label asp-for=\"Location\" class=\"control-label\">Location</label>\n                ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "asp-for", "Location");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 25 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                                       emp.Location

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Location = __value, emp.Location));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", " form-group");
            __builder.AddMarkupContent(45, "<label asp-for=\"Phone\" class=\"control-label\">Phone</label>\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "asp-for", "Phone");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 29 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                                    emp.PhoneNumber

#line default
#line hidden
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.PhoneNumber = __value, emp.PhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "submit");
            __builder.AddAttribute(56, "value", "Save");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                              async () => await UpdateEmployee()

#line default
#line hidden
            ));
            __builder.AddAttribute(58, "class", "btn btn-default");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "submit");
            __builder.AddAttribute(62, "value", "Cancel");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
                                                               cancel

#line default
#line hidden
            ));
            __builder.AddAttribute(64, "class", "btn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 39 "C:\Users\High Tech\Desktop\new\employee-management-blazor-master\BlazorCrud\BlazorCrud\Client\Pages\Employee\EditEmployee.razor"
       

    [Parameter]
    public string empId { get; set; }

    Employee emp = new Employee();

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetJsonAsync<Employee>("/api/Employee/Details/" + Convert.ToInt64(empId));
    }

    protected async Task UpdateEmployee()
    {
        await Http.SendJsonAsync(HttpMethod.Put, "api/Employee/Edit", emp);
        navigation.NavigateTo("/employee");

    }

    void cancel()
    {
        navigation.NavigateTo("/employee");

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
