#pragma checksum "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9123657e186dd6e2c00e8b42120fab5545bc7f99"
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
#line 2 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
using Blazor.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/article/{Id}")]
    public partial class ArticleOne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container flex-fill");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
             articleEntity.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddContent(7, 
#nullable restore
#line 11 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
               (MarkupString)articleEntity.ArticleText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "font-weight-bold mt-xl-3");
            __builder.AddMarkupContent(11, "Дата: ");
            __builder.AddContent(12, 
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
                                                     articleEntity.CreateData.ToString("dd.mm.yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " Автор: ");
            __builder.AddContent(14, 
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
                                                                                                             autorEntity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
           

        [Parameter] public string Id { get; set; }

        Article articleEntity = new Article();
        Autor autorEntity = new Autor();

        protected override async Task OnInitializedAsync()
        {
            articleEntity = await ArticleController.GetById(Convert.ToInt32(Id));
            autorEntity = await AutorController.GetById(Convert.ToInt32(articleEntity.AutorID));

        }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("setTitle", articleEntity.Title); ;
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAutorController AutorController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleController ArticleController { get; set; }
    }
}
#pragma warning restore 1591
