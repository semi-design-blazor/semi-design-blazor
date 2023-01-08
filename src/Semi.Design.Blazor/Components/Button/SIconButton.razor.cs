using Microsoft.AspNetCore.Components.Web;

namespace Semi.Design.Blazor;

public partial class SIconButton
{   [Parameter]
    public bool Secondary { get; set; }

    [Parameter]
    public bool Tertiary { get; set; }

    [Parameter]
    public bool Warning { get; set; }

    [Parameter]
    public bool Danger { get; set; }

    [Parameter]
    public bool Block { get; set; }

    [Parameter]
    public string? Circle { get; set; }

    [Parameter]
    public string? Height { get; set; }

    [Parameter]
    public bool Link { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseDown { get; set; }

    [Parameter]
    public bool Light { get; set; }

    [Parameter]
    public string? Key { get; set; }

    [Parameter]
    public string? Size { get; set; }
    [Parameter]
    public RenderFragment? Icon { get; set; }

    [Parameter]
    public string IconPosition { get; set; }

    [Parameter]
    public IconSize IconSize { get; set; }

    [Parameter]
    public bool Loading { get; set; }

    [Parameter]
    public string Theme { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string[]? NoHorizontalPadding { get; set; }

    public bool SemiChildrenAlias { get; set; }

    public ComponentProvider BtnTextCls { get; } = new();

    public string? XSemiProp { get; set; }

    private string PrefixCls { get; set; } = "semi-icon";

    protected override void OnInitialized()
    {
        if (IconPosition == "right")
        {
            ComponentProvider.CssApply(PrefixCls + "-content-left");
        }
        else if (IconPosition == "left")
        {
            ComponentProvider.CssApply(PrefixCls + "-content-right");
        }

        if (NoHorizontalPadding?.Length > 1)
        {
            if (NoHorizontalPadding.Any(x => x == "left"))
            {
                ComponentProvider.StyleApply("padding-left:0px");
            }
            if (NoHorizontalPadding.Any(x => x == "right"))
            {
                ComponentProvider.StyleApply("padding-right:0px");
            }
        }
        if (NoHorizontalPadding?.Length == 1)
        {
            if (NoHorizontalPadding.Any(x => x == "true"))
            {
                ComponentProvider.StyleApply("padding-left:0px");
                ComponentProvider.StyleApply("padding-right:0px");
            }
            else if (NoHorizontalPadding.Any(x => x == "left"))
            {
                ComponentProvider.StyleApply("padding-left:0px");
            }
            else if (NoHorizontalPadding.Any(x => x == "right"))
            {
                ComponentProvider.StyleApply("padding-right:0px");
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
            ComponentProvider.CssApply(PrefixCls + "-with-icon-only");
        }
        if (Loading)
        {
            ComponentProvider.CssApply(PrefixCls + "-loading");
        }

        base.OnInitialized();
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        if (Loading)
        {
            ComponentProvider.CssApply(PrefixCls + "-loading");
        }
    }
}