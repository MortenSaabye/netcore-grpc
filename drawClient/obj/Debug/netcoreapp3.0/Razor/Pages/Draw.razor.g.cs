#pragma checksum "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba3be9a92ad6aa12fa579dd07cfb11a029d179e"
// <auto-generated/>
#pragma warning disable 1591
namespace drawClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using drawClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/idealpraktik/examples/grpc/drawClient/_Imports.razor"
using drawClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/draw")]
    public partial class Draw : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p>sdfsdfsdfsdfsd</p>\n");
            __builder.OpenElement(1, "canvas");
            __builder.AddAttribute(2, "width", "1000");
            __builder.AddAttribute(3, "height", "800");
            __builder.AddAttribute(4, "style", "background-color:aqua");
            __builder.AddAttribute(5, "id", "drawCanvas");
            __builder.AddAttribute(6, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor"
                                                                                             (e => draw(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor"
                                                                                                                           (e => mouseDown(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor"
                                                                                                                                                            mouseUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor"
                                                                                                                                                                                  mouseUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\n<hr>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/idealpraktik/examples/grpc/drawClient/Pages/Draw.razor"
       
    private bool isDrawing;

    protected override void OnInitialized()
    {  
        JSRuntime.InvokeAsync<string>("startDrawing");
    }

    private void mouseUp()
    {
        isDrawing = false;
        JSRuntime.InvokeAsync<string>("endDrawing");
    }

    private void mouseDown(MouseEventArgs e)
    {
        isDrawing = true;
    }

    private void draw(MouseEventArgs e)
    {
        if(!isDrawing) return;
        JSRuntime.InvokeAsync<string>("drawPoint", e.ClientX, e.ClientY);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
