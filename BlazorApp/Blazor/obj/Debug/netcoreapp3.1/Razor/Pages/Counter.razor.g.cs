#pragma checksum "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7532c3d209377f2a2b05f50094fb81bc6bbf526c"
// <auto-generated/>
#pragma warning disable 1591
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
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
using Blazor.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
               SetCoordinates

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "container-fluid border border-dark");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h1>Blazor Counter</h1>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "span");
            __builder.AddContent(12, 
#nullable restore
#line 14 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
               currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                          DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.AddMarkupContent(19, "<p><span class=\"border border-danger\">Ctrl +</span> - увеличивает на 10</p>\r\n    ");
            __builder.AddMarkupContent(20, "<p><span class=\"border border-danger\">>Alt -</span> - уменьшает на 10</p>\r\n    ");
            __builder.AddMarkupContent(21, "<p>***</p>\r\n    ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "Кука X: ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                x

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, " Кука Y: ");
            __builder.AddContent(26, 
#nullable restore
#line 21 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                           y

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<p>***</p>\r\n\r\n    ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "Координата X: ");
            __builder.AddContent(31, 
#nullable restore
#line 24 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                      coordX

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "Координата Y: ");
            __builder.AddContent(35, 
#nullable restore
#line 25 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
                      coordY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Repository\BlazorApp\Blazor\Pages\Counter.razor"
       
#nullable enable

    private int currentCount = 0;
    private double coordX;
    private double coordY;

    public string? x;
    public string? y;


    protected override async Task OnInitializedAsync()
    {
        x = await SetCookies.CookiesRequest("X");
        y = await SetCookies.CookiesRequest("Y");
    }

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

    private async Task SetCoordinates(MouseEventArgs e)
    {
        int days = 6;
        coordX = e.ClientX;
        coordY = e.ClientY;
        await WriteCookieAsync("X", coordX.ToString(), days);
        await WriteCookieAsync("Y", coordY.ToString(), days);

        await OnInitializedAsync();

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", "Тренируемся");
    }

    public async Task WriteCookieAsync(string name, string value, int days)
    {
        await JSRuntime.InvokeAsync<string>("WriteCookie", name, value, days);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SetCookies SetCookies { get; set; }
    }
}
#pragma warning restore 1591
