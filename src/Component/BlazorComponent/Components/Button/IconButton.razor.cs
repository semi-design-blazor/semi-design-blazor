namespace BlazorComponent;

public partial class IconButton
{
    [Parameter]
    public RenderFragment? Icon { get; set; }

    [Parameter]
    public string IconPosition { get; set; }

    [Parameter]
    public IconSize IconSize { get; set; }

    [Parameter]
    public bool Loading { get; set; }

    [Parameter]
    public Theme Theme { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string[]? NoHorizontalPadding { get; set; }

    public string PrefixCls { get; set; } = "semi-icon";

    protected override void OnInitialized()
    {
        if (IconPosition == "right")
        {
            CssProvider.CssApply(PrefixCls + "-content-left");
        }
        else if (IconPosition == "left")
        {
            CssProvider.CssApply(PrefixCls + "-content-right");
        }

        if (NoHorizontalPadding?.Length > 1)
        {
            
        }

        base.OnInitialized();
    }
}
