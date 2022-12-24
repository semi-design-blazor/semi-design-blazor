using Microsoft.AspNetCore.Components;
using Semi.Design.Shared.Options;
using System.Net.Http.Json;

namespace Semi.Design.Shared.Shared;

public partial class MainLayout
{
    #region inject

    [Inject]
    public required IHttpClientFactory HttpClientFactory { get; set; }

    //[Inject]
    public  Navigation? Navigation { get; set; }

    #endregion

    protected override async Task OnInitializedAsync()
    {
        var client = HttpClientFactory.CreateClient("docs");
        Navigation = await client.GetFromJsonAsync<Navigation>("_content/Semi.Design.Shared/navigation.json") ?? new Navigation();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        
        await base.OnAfterRenderAsync(firstRender);
    }
}
