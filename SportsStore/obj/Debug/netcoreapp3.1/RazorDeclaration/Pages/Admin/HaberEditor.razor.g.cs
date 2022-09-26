#pragma checksum "C:\Users\User\Desktop\SportsStore\Pages\Admin\HaberEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77aa178423c9c47897a9091f074783fb7fb9b9eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SportsStore.Pages.Admin
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\SportsStore\Pages\Admin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\SportsStore\Pages\Admin\HaberEditor.razor"
using SportsStore.Pages.Admin.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler/edit/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler/create")]
    public partial class HaberEditor : OwningComponentBase<INewsRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\User\Desktop\SportsStore\Pages\Admin\HaberEditor.razor"
        public INewsRepository Repository => Service;
    [Parameter]
    public int Id { get; set; } = 0;

    public NewsEkle News { get; set; } = new NewsEkle();

    [Inject]
    public NavigationManager NavManager { get; set; }

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            News = Repository.Haberler.FirstOrDefault(p => p.NewsID == Id);
        }
    }

    public void SaveNews()
    {

        if (Id == 0)
        {
            News.ResimYol = "/img/" + file.Name;
            Repository.CreateNews(News);
        }
        else
        {
            News.ResimYol = "/img/" + file.Name;
            Repository.SaveNews(News);
        }
        NavManager.NavigateTo("/admin/haberler");
    }

    BlazorInputFile.IFileListEntry file;
    async Task HandleFileSelected(BlazorInputFile.IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);
        }
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit"; 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591