#pragma checksum "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4454d40b459a75810301ea457172ccc7a2d6454"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
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
#nullable restore
#line 2 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
       
#nullable enable

    private int currentCount = 0;
    private double coordX;
    private double coordY;
    //public HttpContext mycontext = new HttpContextAccessor().HttpContext;


    private async Task IncrementCount(MouseEventArgs e)
    {
        await Task.Delay(500);
        if (e.CtrlKey == true) currentCount = currentCount + 10;
        else currentCount++;
    }
    private async Task DecrementCount(MouseEventArgs e)
    {
        await Task.Delay(500);
        if (e.AltKey == true) currentCount = currentCount - 10;
        else currentCount--;
    }

    //public int? coo;

    private void SetCoordinates(MouseEventArgs e)
    {
        coordX = e.ClientX;
        coordY = e.ClientY;
        //mycontext.Response.Cookies.Append("Bob","Smith");
        //coo = mycontext.Request.Cookies.Count;
        //mycontext.Response.Cookies.Append("X", "XXX");
        //mycontext.HttpContext.Response.Cookies.Append("Y", "YYY");

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", "Тренируемся");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
