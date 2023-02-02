namespace Semi.Design.Blazor;

public partial class SButtonGroup
{
    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string? Size { get; set; }

    [Parameter]
    public string? Theme { get; set; }

    [Parameter]
    public string? Type { get; set; }
    
    [Parameter]
    public bool Secondary { get; set; }

    [Parameter]
    public bool Tertiary { get; set; }

    [Parameter]
    public bool Warning { get; set; }

    [Parameter]
    public bool Danger { get; set; }

    [Parameter]
    public bool Link { get; set; }
    
    public override async Task SetParametersAsync(ParameterView parameters)
    {
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
        ComponentProvider.CssApply("semi-button-group-line-" + Theme ?? "light");
        ComponentProvider.CssApply("semi-button-group-line-" + Type ?? "primary");
        if (Disabled)
        {
            ComponentProvider.CssApply("semi-button-group-line-disabled");
        }
        await base.OnInitializedAsync();
    }
}