// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinanceMentorTutorial.Client.Pages
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
#line 1 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Pages\Expenses.razor"
using FinanceMentorTutorial.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Pages\Expenses.razor"
using FinanceMentorTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Pages\Expenses.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/expenses")]
    public partial class Expenses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Dominik\source\repos\FinanceMentorTutorial\FinanceMentorTutorial\Client\Pages\Expenses.razor"
       
    private Expense[] expenses;

    private Expense _expenseDelete;

    public bool DeleteDialogOpen { get; set; }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            await Http.DeleteAsync($"api/Expenses/{_expenseDelete.Id}");
            await LoadData();
            _expenseDelete = null;
        }
        DeleteDialogOpen = false;
        StateHasChanged();
    }

    private void OpenDeleteDialog(Expense expense)
    {
        DeleteDialogOpen = true;
        _expenseDelete = expense;
        StateHasChanged();
    }

    protected async override Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        expenses = await Http.GetFromJsonAsync<Expense[]>("api/Expenses");
        StateHasChanged();
    }

    public async void Refresh()
    {
        await LoadData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
