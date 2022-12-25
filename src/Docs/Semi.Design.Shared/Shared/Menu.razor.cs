using Microsoft.AspNetCore.Components;
using Semi.Design.Shared.Options;
using Token.Events;

namespace Semi.Design.Shared.Shared;

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

    public async void GoTo(string component)
    {
        await KeyLoadEventBus.PushAsync("Component", component);
        NavigationManager.NavigateTo("/component/" + component);
    }
}
