using Microsoft.AspNetCore.Components;
using Semi.Design.Docs.Server.Options;
using Token.Events;

namespace Semi.Design.Docs.Server.Shared;

public partial class Menu
{
    #region inject

    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    [Inject]
    public required IKeyLoadEventBus KeyLoadEventBus { get; set; }

    #endregion

    [Parameter]
    public required MenuTree[] MenuTree { get; set; }


    public void Show(MenuTree tree)
    {
        tree.Show = !tree.Show;
        StateHasChanged();
    }

    public async void GoTo(string path)
    {
        await KeyLoadEventBus.PushAsync("Component", path);
        NavigationManager.NavigateTo("?path=" + path);
    }
}
