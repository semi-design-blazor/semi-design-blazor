using Microsoft.AspNetCore.Components;
using System.IO;
using System.Reflection;
using Token.Events;

namespace Semi.Design.Shared.Pages;

public partial class Index
{
    #region inject

    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    [Inject]
    public required IKeyLoadEventBus KeyLoadEventBus { get; set; }

    #endregion

    [Parameter]
    public string? Component { get; set; }

    public Type? ComponentType { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        KeyLoadEventBus.Subscription("Component", (value) =>
        {
            LoadComponent((string)value);
        });
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);
        LoadComponent();
    }

    public async void LoadComponent(string? component = null)
    {
        if (string.IsNullOrEmpty(Component) && string.IsNullOrEmpty(component))
        {
            return;
        }

        if (!string.IsNullOrEmpty(component))
        {
            Component = component;
        }

        var types = Assembly.GetExecutingAssembly()
        .GetTypes()
            .FirstOrDefault(x => x.FullName.ToLower() == $"Semi.Design.Shared.Component.{Component?.Replace('-', '.')}".ToLower());
        if (types != null && types != ComponentType)
        {
            ComponentType = types;
            _ = InvokeAsync(StateHasChanged);
        }
    }
}
