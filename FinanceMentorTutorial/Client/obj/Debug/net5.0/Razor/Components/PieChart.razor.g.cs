#pragma checksum "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe711fab5aa0e5ec3c8872cf05a7a41994793c7"
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
#nullable restore
#line 1 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
using FinanceMentorTutorial.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class PieChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin-top:15px;margin-right:90px;text-align:center;");
            __builder.OpenElement(3, "b");
#nullable restore
#line 3 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
__builder.AddContent(4, Data.Label);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.FinanceMentorTutorial.Client.Components.PieChart.TypeInference.CreateRadzenPieSeries_0(__builder2, 8, 9, 
#nullable restore
#line 5 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
                                 Colors

#line default
#line hidden
#nullable disable
                , 10, 
#nullable restore
#line 6 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
                                Data.Data

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 7 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
                                 Data.Label

#line default
#line hidden
#nullable disable
                , 12, "Category", 13, "Amount");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Components\PieChart.razor"
       
    [Parameter]
    public ICollection<string> Colors { get; set; }
    [Parameter]
    public MonthlyData Data { get; set; }
    [Parameter]
    public string Label { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FinanceMentorTutorial.Client.Components.PieChart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenPieSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.String> __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenPieSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Fills", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "CategoryProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
