#pragma checksum "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e501adf6a8d4777c78a46f7c785f957c3cea150f"
// <auto-generated/>
#pragma warning disable 1591
namespace UI.BlazorWASM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using UI.BlazorWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using UI.BlazorWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Core.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Core.Interfaces.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Core.Interfaces.ECommerceItems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using Core.Interfaces.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\_Imports.razor"
using UI.BlazorWASM.Models.ECommerceItems;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-zkmzcubc4b");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-zkmzcubc4b>UI.BlazorWASM</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-zkmzcubc4b");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-zkmzcubc4b></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-zkmzcubc4b");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-zkmzcubc4b");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-zkmzcubc4b");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-zkmzcubc4b></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-zkmzcubc4b");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "counter");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-zkmzcubc4b></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-zkmzcubc4b");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "fetchdata");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-zkmzcubc4b></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\CalismaAlani\CSharpProjeleri\ECommerce\src\.net\UI.BlazorWASM\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
