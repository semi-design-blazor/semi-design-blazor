using Microsoft.AspNetCore.Components;
using Semi.Design.Blazor;
using Token.Events;

namespace Semi.Design.Docs.Server.Shared;

public partial class Title
{
    private string Theme = "dark";

    [Inject]
    public required HelperJsInterop HelperJsInterop { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    private async void OnThemeChanged()
    {
        if (Theme == "dark")
        {
            Theme = "";
        }
        else
        {
            Theme = "dark";
        }

        await HelperJsInterop.SetTheme(Theme);
    }
}
