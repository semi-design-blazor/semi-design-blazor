using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

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
        CssProvider?.StyleApply(Style);

        if (Disabled)
        {
            CssProvider?.CssApply(PrefixCls + "-disabled");
        }

        CssProvider.CssApply(PrefixCls);

        if (!string.IsNullOrEmpty(Class))
        {
            CssProvider?.CssApply(Class);
        }

        if (!string.IsNullOrEmpty(Size))
        {
            CssProvider?.CssApply(PrefixCls + "-size-" + Size.ToLower());
        }

        if (!string.IsNullOrEmpty(Theme))
        {
            CssProvider?.CssApply(PrefixCls + "-"+Theme.ToLower());
        }
        else
        {
            CssProvider?.CssApply(PrefixCls + "-light");
        }

        if (Secondary)
        {
            CssProvider?.CssApply(PrefixCls + "-secondary");
        }
        else if (Tertiary)
        {
            CssProvider?.CssApply(PrefixCls + "-tertiary");
        }
        else if (Warning)
        {
            CssProvider?.CssApply(PrefixCls + "-warning");
        }
        else if (Danger)
        {
            CssProvider?.CssApply(PrefixCls + "-danger");
        }
        else
        {
            CssProvider?.CssApply(PrefixCls + "-primary");
        }
        base.OnInitialized();
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);
    }
}