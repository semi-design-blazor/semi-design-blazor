using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorComponent;

public abstract class SDomComponentBase : SComponentBase
{
    [Parameter] 
    public string? Id { get; set; }

    /// <summary>
    /// Specifies one or more class names for an DOM element.
    /// </summary>
    [Parameter]
    public string? Class { get; set; }

    /// <summary>
    /// Specifies an inline style for an DOM element.
    /// </summary>
    [Parameter]
    public string? Style { get; set; }

    /// <summary>
    /// Custom attributes
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public virtual IDictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();

    
    public ComponentCssProvider CssProvider { get; } = new();

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        base.BuildRenderTree(builder);
    }

    protected override Task OnInitializedAsync()
    {
        Id ??= Guid.NewGuid().ToString("N");
        
        return base.OnInitializedAsync();
    }
}