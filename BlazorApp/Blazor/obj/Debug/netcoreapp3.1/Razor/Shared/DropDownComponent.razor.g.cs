#pragma checksum "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8641d27a3e48b8ca23427119b663a936ef17cf"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class DropDownComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-right");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "dropdown" + " " + (
#nullable restore
#line 2 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                           Active ? "show" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                          DropDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-secondary dropdown-toggle");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "id", "dropdownMenu2");
            __builder.AddAttribute(9, "data-toggle", "dropdown");
            __builder.AddContent(10, 
#nullable restore
#line 4 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "dropdown-menu" + " dropdown-menu-right" + " " + (
#nullable restore
#line 6 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                                                        Active ? "show" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "aria-labelledby", "dropdownMenu2");
#nullable restore
#line 7 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
             foreach (var i in DDItem) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "dropdown-item" + " " + (
#nullable restore
#line 8 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                                           QuantityPerPage == i ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                                                                                                            () => SelectDropDown(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 8 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
                                                                                                                                      i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
 
        [Parameter] public string Title { get; set; }
        [Parameter] public int QuantityPerPage { get; set; }
        [Parameter] public int[] DDItem { get; set; }
    [Parameter] public EventCallback<int> SetQuantityPerPage { get; set; }


    private bool Active = false;


    private void DropDown()
    {
        if (!Active)
        {
            Active = true;
        }
        else
        {
            Active = false;
        }

    }

    private async Task SelectDropDown(int q)
    {
        await SetQuantityPerPage.InvokeAsync(q);
        DropDown();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
