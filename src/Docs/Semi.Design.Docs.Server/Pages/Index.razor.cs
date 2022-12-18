using Microsoft.AspNetCore.Components;
using System.Reflection;
using System.Web;
using Token.Events;

namespace Semi.Design.Docs.Server.Pages;

public partial class Index
{
    #region inject

    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    [Inject]
    public required IKeyLoadEventBus KeyLoadEventBus { get; set; }

    #endregion

    public Type? ComponentType { get; set; }

    protected override void OnInitialized()
    {
        KeyLoadEventBus.Subscription("Component", (obj) =>
        {
            var value = obj as string;
            if (value != null)
            {
                LoadComponent(value);
            }
        });

        var uri = NavigationManager.Uri.Split("?");
        string value = string.Empty;
        if (uri.Length <= 1)
        {
            return;
        }

        value = uri[1];

        var query = HttpUtility.ParseQueryString(value);
        var path = query["path"];
        if (!string.IsNullOrEmpty(path))
        {
            LoadComponent(path);
        }

        base.OnInitialized();
    }


    public void LoadComponent(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return;
        }

        var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(x => x.FullName == $"Semi.Design.Docs.Server.Component.{path.Replace('-', '.')}");
        if (types != null)
        {
            ComponentType = types;
            _ = InvokeAsync(StateHasChanged);
        }
    }
}
