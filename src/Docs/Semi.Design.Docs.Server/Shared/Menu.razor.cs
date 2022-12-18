﻿using Microsoft.AspNetCore.Components;
using Semi.Design.Docs.Server.Options;

namespace Semi.Design.Docs.Server.Shared;

public partial class Menu
{
    #region inject

    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    #endregion

    [Parameter]
    public required MenuTree[] MenuTree { get; set; }


    public void Show(MenuTree tree)
    {
        tree.Show = !tree.Show;
        StateHasChanged();
    }

    public void GoTo(string path)
    {
        NavigationManager.NavigateTo("?path=" + path);
    }
}
