#pragma checksum "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321641ee324e80125e7fed7fcb5e0151ce1ba10f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/article/{Id:int}")]
    public partial class ArticleOne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "h3");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddContent(6, 
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
           (MarkupString)ArticleText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "font-weight-bold mt-xl-3");
            __builder.AddMarkupContent(10, "Дата: ");
            __builder.AddContent(11, 
#nullable restore
#line 11 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
                                                 CreateData

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, " Автор: ");
            __builder.AddContent(13, 
#nullable restore
#line 11 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
                                                                    Autor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\Pages\ArticleOne.razor"
       
    [Parameter] public int Id { get; set; }

    private Article? articleEntity = new Article();
    private Autor autorEntity = new Autor();
    private string Title, ArticleText, CreateData, Autor;

    protected override async Task OnInitializedAsync()
    {
        articleEntity = await ArticleController.GetById(Id);
        if (articleEntity != null)
        {
            autorEntity = await AutorController.GetById(Convert.ToInt32(articleEntity.AutorID));
            Title = articleEntity.Title;
            ArticleText = articleEntity.ArticleText;
            CreateData = articleEntity.CreateData.ToString("dd.mm.yyyy");
            Autor = autorEntity.Name;
        }
        else
        {
            Title = "Извините!";
            ArticleText = "Такой статьи нет или она была удалена";
            CreateData = DateTime.Now.ToString("dd.mm.yyyy");
            Autor = "Администрация сайта";
        }

    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", Title); ;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IController<Autor> AutorController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IController<Article> ArticleController { get; set; }
    }
}
#pragma warning restore 1591
