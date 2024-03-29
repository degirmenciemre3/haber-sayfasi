#pragma checksum "C:\Users\User\Desktop\SportsStore\Pages\Admin\Haberler.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0135b890f7c49b716c67e28ad2b55b915844e378"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Haberler : OwningComponentBase<INewsRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\User\Desktop\SportsStore\Pages\Admin\Haberler.razor"
        public INewsRepository Repository => Service;

    public IEnumerable<NewsEkle> Newsdata { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        Newsdata = await Repository.Haberler.ToListAsync();
    }

    public async Task DeleteNews(NewsEkle p)
    {
        Repository.DeleteNews(p);
        await UpdateData();
    }

    public string GetDetailsUrl(int id) => $"/admin/haberler/details/{id}";
    public string GetEditUrl(int id) => $"/admin/haberler/edit/{id}"; 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
