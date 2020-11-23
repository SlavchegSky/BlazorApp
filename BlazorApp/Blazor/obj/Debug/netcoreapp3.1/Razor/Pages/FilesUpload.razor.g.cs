#pragma checksum "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d05b936a09549c0c90ac262049cdeb5405040c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/filesupload")]
    public partial class FilesUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3>Загрузка файлов</h3>\r\n    ");
            __builder.AddMarkupContent(4, "<h4>Выберите файл для загрузки</h4>\r\n\r\n    ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(5);
            __builder.AddAttribute(6, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 9 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                         HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
#nullable restore
#line 11 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
     if (file != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Name: ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                  file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Size: ");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                  file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Type: ");
            __builder.AddContent(19, 
#nullable restore
#line 15 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                  file.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Data: ");
            __builder.AddContent(23, 
#nullable restore
#line 16 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                  file.LastModified

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Status: ");
            __builder.AddContent(27, 
#nullable restore
#line 17 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                    status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 18 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 20 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
     if (files != null)
    {
        foreach (var f in files)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", "/upload/images/" + (
#nullable restore
#line 24 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
                                      f.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 25 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Repository\BlazorApp\Blazor\Pages\FilesUpload.razor"
       
    public string? status;
    public IFileListEntry? file;
    public List<FileModel>? files;

    async Task HandleSelection(IFileListEntry[] fileEntry)
    {
        file = fileEntry.FirstOrDefault();
        status = "Загружается файл";

        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            //var ms = new MemoryStream();
            //await file.Data.CopyToAsync(ms);

            if (await UploadFile.UploadAsync(file))
            {
                status = $"Finished loading {file.Size} bytes from {file.Name}";
            }
            else
            {
                status = "Что-то пошло не так";
            }

        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", "Загрузка файлов");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UploadFilesController UploadFile { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
