#pragma checksum "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3bad5ae53661d298e6c4e1fdb5119c6c3f7784"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class DropDownComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\Shared\DropDownComponent.razor"
 
    [Parameter] public string Title { get; set; }
    [Parameter] public int QuantityPerPage { get; set; }
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