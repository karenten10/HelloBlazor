#pragma checksum "/Users/karen/Projects/HelloBlazor/HelloBlazor/Pages/Dialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f294cb396523303792b466c598451fb634529837"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HelloBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using HelloBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/karen/Projects/HelloBlazor/HelloBlazor/_Imports.razor"
using HelloBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/karen/Projects/HelloBlazor/HelloBlazor/Pages/Dialog.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private void OnYes()
    {
        Console.WriteLine("Write to the console in C#! 'Yes' button was selected.");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
