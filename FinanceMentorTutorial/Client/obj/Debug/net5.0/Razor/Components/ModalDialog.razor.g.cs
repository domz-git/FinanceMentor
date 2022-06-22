#pragma checksum "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "818054292e12213459e96d3436f2cc5abe1086fe"
// <auto-generated/>
#pragma warning disable 1591
namespace FinanceMentorTutorial.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using FinanceMentorTutorial.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using FinanceMentorTutorial.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class ModalDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block;background-color:rgba(10,10,10,.8);");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "modal-title");
#nullable restore
#line 5 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
__builder.AddContent(14, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-body");
            __builder.OpenElement(24, "p");
#nullable restore
#line 9 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
__builder.AddContent(25, Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-footer");
#nullable restore
#line 12 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                 switch (DialogType)
                {
                    case ModalDialogType.Ok:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                                                 ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "OK");
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                        break;
                    case ModalDialogType.OkCancel:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                                     ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                                                 ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "OK");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                        break;
                    case ModalDialogType.DeleteCancel:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                         ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-danger");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                                                                                ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Delete");
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
                        break;
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\ModalDialog.razor"
      
    [Parameter]
                    public string Title { get; set; }
                    [Parameter]
                    public string Text { get; set; }
                    [Parameter]
                    public EventCallback<bool> OnClose { get; set; }
                    [Parameter]
                    public ModalDialogType DialogType { get; set; }

                    private Task ModalCancel()
                    {
                        return OnClose.InvokeAsync(false);
                    }

                    private Task ModalOk()
                    {
                        return OnClose.InvokeAsync(true);
                    }

                    public enum ModalDialogType
                    {
                        Ok,
                        OkCancel,
                        DeleteCancel,
                    }

                

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
