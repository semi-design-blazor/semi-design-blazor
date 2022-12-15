using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

public partial class SButton
{
    [Parameter] public bool Secondary { get; set; }

    [Parameter] public bool Tertiary { get; set; }

    [Parameter] public bool Warning { get; set; }

    [Parameter] public bool Danger { get; set; }

    [Parameter] public bool Block { get; set; }

    [Parameter] public string? Circle { get; set; }

    [Parameter] public string? Height { get; set; }

    [Parameter] public bool Link { get; set; }

    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }

    [Parameter] public EventCallback<MouseEventArgs> OnMouseDown { get; set; }

    [Parameter] public bool Light { get; set; }

    [Parameter] public string? Key { get; set; }

    [Parameter] public bool Disabled { get; set; }

    [Parameter]
    public string? Theme { get; set; }

    [Parameter]
    public string? Size { get; set; }

    [Parameter]
    public ComponentCssProvider? CssProvider { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override void OnInitialized()
    {
        CssProvider = new ComponentCssProvider();

        CssProvider?.StyleApply(Style);

        if (Disabled)
        {
            CssProvider?.CssApply("semi-disabled");
        }

        CssProvider?.CssApply(Class)
            .CssApply("semi-" + Size)
            .CssApply("semi-" + Theme)
            .CssApply("semi-" + Block)
            .CssApply("semi-button semi-button-light");
        if (Secondary)
        {
            CssProvider?.CssApply("semi-button-secondary");
        }
        else if (Tertiary)
        {
            CssProvider?.CssApply("semi-button-tertiary");
        }
        else if (Warning)
        {
            CssProvider?.CssApply("semi-button-warning");
        }
        else if (Danger)
        {
            CssProvider?.CssApply("semi-button-danger");
        }
        else
        {
            CssProvider?.CssApply("semi-button-primary");
        }
        base.OnInitialized();
    }
    
}