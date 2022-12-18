using Microsoft.AspNetCore.Components;
using Semi.Design.Docs.Server.Options;

namespace Semi.Design.Docs.Server.Shared;

public partial class MainLayout
{
    #region inject

    [Inject]
    public required Navigation Navigation { get; set; }

    #endregion

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }
}
