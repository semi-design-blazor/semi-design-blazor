using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;

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

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Style))
        {
            CssProvider.StyleApply(Style!);
        }
        CssProvider.StyleApply("height:auto;");
        if (!string.IsNullOrEmpty(Class))
        {
            CssProvider.CssApply(Class!);
        }
        CssProvider.CssApply("semi-button-group");
        CssProvider.CssApply("semi-button-group-line-" + Threme ?? "light");
        CssProvider.CssApply("semi-button-group-line-" + Type ?? "primary");
        if (Disabled)
        {
            CssProvider.CssApply("semi-button-group-line-disabled");
        }
        await base.OnInitializedAsync();
    }


}