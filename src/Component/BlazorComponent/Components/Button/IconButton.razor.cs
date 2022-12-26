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

    public bool SemiChildrenAlias { get; set; }

    public ComponentCssProvider BtnTextCls { get; } = new();

    public string? XSemiProp { get; set; }

    private string PrefixCls { get; set; } = "semi-icon";

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
            if (NoHorizontalPadding.Any(x => x == "left"))
            {
                CssProvider.StyleApply("padding-left:0px");
            }
            if (NoHorizontalPadding.Any(x => x == "right"))
            {
                CssProvider.StyleApply("padding-right:0px");
            }
        }
        if (NoHorizontalPadding?.Length == 1)
        {
            if (NoHorizontalPadding.Any(x => x == "true"))
            {
                CssProvider.StyleApply("padding-left:0px");
                CssProvider.StyleApply("padding-right:0px");
            }
            else if (NoHorizontalPadding.Any(x => x == "left"))
            {
                CssProvider.StyleApply("padding-left:0px");
            }
            else if (NoHorizontalPadding.Any(x => x == "right"))
            {
                CssProvider.StyleApply("padding-right:0px");
            }
        }

        if (SemiChildrenAlias)
        {
            XSemiProp = "x-semi-children-alias";
        }
        else
        {
            XSemiProp = "children";
        }

        if (ChildContent == null)
        {
            CssProvider.CssApply(PrefixCls + "-with-icon-only");
        }
        if (Loading)
        {
            CssProvider.CssApply(PrefixCls + "-loading");
        }

        base.OnInitialized();
    }
}
