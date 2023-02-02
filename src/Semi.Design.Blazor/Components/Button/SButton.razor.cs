using Microsoft.AspNetCore.Components.Web;

namespace Semi.Design.Blazor;

public partial class SButton
{
    [Parameter]
    [CascadingParameter(Name = nameof(Secondary))]
    public bool Secondary { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Tertiary))]
    public bool Tertiary { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Warning))]
    public bool Warning { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Danger))]
    public bool Danger { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Link))]
    public bool Link { get; set; }
    
    [Parameter]
    [CascadingParameter(Name = nameof(Disabled))]
    public bool Disabled { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Theme))]
    public string? Theme { get; set; }

    [Parameter]
    [CascadingParameter(Name = nameof(Size))]
    public string? Size { get; set; }
    
    [Parameter]
    public bool Block { get; set; }

    [Parameter]
    public string? Circle { get; set; }

    [Parameter]
    public string? Height { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseDown { get; set; }

    [Parameter]
    public bool Light { get; set; }

    [Parameter]
    public string? Key { get; set; }

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

}