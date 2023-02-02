using Microsoft.AspNetCore.Components.Web;

namespace Semi.Design.Blazor;

public partial class SButton
{
    [Parameter]
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
    public bool Disabled { get; set; }

    [Parameter]
    public string? Theme { get; set; }

    [Parameter]
    public string? Size { get; set; }


    private const string PrefixCls = "semi-button";

    protected override void OnInitialized()
    {
        ComponentProvider?.StyleApply(Style);

        if (Disabled)
        {
            ComponentProvider?.CssApply(PrefixCls + "-disabled");
        }

        ComponentProvider.CssApply(PrefixCls);

        if (!string.IsNullOrEmpty(Class))
        {
            ComponentProvider?.CssApply(Class);
        }

        if (!string.IsNullOrEmpty(Size))
        {
            ComponentProvider?.CssApply(PrefixCls + "-size-" + Size.ToLower());
        }

        if (!string.IsNullOrEmpty(Theme))
        {
            ComponentProvider?.CssApply(PrefixCls + "-" + Theme.ToLower());
        }
        else
        {
            ComponentProvider?.CssApply(PrefixCls + "-light");
        }

        if (Secondary)
        {
            ComponentProvider?.CssApply(PrefixCls + "-secondary");
        }
        else if (Tertiary)
        {
            ComponentProvider?.CssApply(PrefixCls + "-tertiary");
        }
        else if (Warning)
        {
            ComponentProvider?.CssApply(PrefixCls + "-warning");
        }
        else if (Danger)
        {
            ComponentProvider?.CssApply(PrefixCls + "-danger");
        }
        else
        {
            ComponentProvider?.CssApply(PrefixCls + "-primary");
        }
        base.OnInitialized();
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);
    }
}