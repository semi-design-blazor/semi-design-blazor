namespace BlazorComponent;

public partial class SButtonGroup
{

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string? Size { get; set; }

    [Parameter]
    public string? Threme { get; set; }

    [Parameter]
    public string? Type { get; set; }

    private ParameterView _parameters;

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        _parameters = parameters;

        await base.SetParametersAsync(parameters);
    }

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Style))
        {
            ComponentProvider.StyleApply(Style!);
        }
        ComponentProvider.StyleApply("height:auto;");
        if (!string.IsNullOrEmpty(Class))
        {
            ComponentProvider.CssApply(Class!);
        }
        ComponentProvider.CssApply("semi-button-group");
        ComponentProvider.CssApply("semi-button-group-line-" + Threme ?? "light");
        ComponentProvider.CssApply("semi-button-group-line-" + Type ?? "primary");
        if (Disabled)
        {
            ComponentProvider.CssApply("semi-button-group-line-disabled");
        }
        await base.OnInitializedAsync();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }
}