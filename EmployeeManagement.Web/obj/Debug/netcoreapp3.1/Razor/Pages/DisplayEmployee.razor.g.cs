#pragma checksum "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d9fc441bc168d7fd52791bc651451f54beba3e"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using CompanyName.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, 
#nullable restore
#line 5 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
             Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 5 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                 Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "checkbox");
            __builder.AddAttribute(14, "checked", 
#nullable restore
#line 6 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                         IsSelected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                                CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 9 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 10 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-footer text-center");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 13 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn btn-primary m-1");
            __builder.AddContent(29, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 16 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-primary m-1");
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.AddMarkupContent(36, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 20 "C:\VS-Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
