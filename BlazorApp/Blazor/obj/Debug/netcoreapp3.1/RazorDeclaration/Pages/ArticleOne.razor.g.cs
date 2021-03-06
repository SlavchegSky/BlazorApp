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
