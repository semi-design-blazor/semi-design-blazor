using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorComponent.Components.Button;
public partial class SButton
{

    [Parameter]
    public bool Block { get; set; }

    [Parameter]
    public string Circle { get; set; }

    [Parameter]
    public string Height { get; set; }

    [Parameter]
    public RenderFragment LoaderContent { get; set; }

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
    public string Theme { get; set; }

    [Parameter]
    public string Size { get; set; }

    [Parameter]
    public ComponentCssProvider CssProvider { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            if (Disabled)
            {
                CssProvider
                    .Apply("semi-disabled");
            }

            CssProvider.Apply("semi-" + Size)
                .Apply("semi-" + Theme)
                .Apply("semi-" + Block);

        }
        base.OnAfterRender(firstRender);
    }
}
