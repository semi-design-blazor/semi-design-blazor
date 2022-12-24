using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

public class SIcon:  SDomComponentBase
{
    /// <summary>
    /// svg data
    /// </summary>
    [Parameter]
    public virtual RenderFragment Svg { get; set; }

    /// <summary>
    /// icon size
    /// </summary>
    [Parameter] 
    public IconSize Size { get; set; } = IconSize.Default;

    /// <summary>
    /// spin
    /// </summary>
    [Parameter] 
    public bool Spin { get; set; } = false;

    /// <summary>
    /// rotate
    /// </summary>
    [Parameter] 
    public double Rotate { get; set; } = 0d;
    
    [Parameter]
    public string Label { get; set; }



    #region event

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseDown { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> onMouseEnter { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> onMouseLeave { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> onMouseMove { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> onMouseUp { get; set; }

    #endregion
    
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var sizeStyle = Size switch
        {
            IconSize.Default => StyleCons.Default,
            IconSize.Small => StyleCons.Small,
            IconSize.ExtraSmall => StyleCons.ExtraSmall,
            IconSize.Large => StyleCons.Large,
            IconSize.ExtraLarge => StyleCons.ExtraLarge,
            _ => ""
        };

        CssProvider.CssApply(StyleCons.PrefixCls);

        CssProvider.CssApply(sizeStyle);

        if (Spin)
        {
            CssProvider.CssApply($"{StyleCons.PrefixCls}-spinning");
        }

        if (!string.IsNullOrWhiteSpace(Label))
        {
            CssProvider.CssApply($"{StyleCons.PrefixCls}-{Label}");
        }

        if (this.Spin)
        {
            CssProvider.CssApply(StyleCons.Spinning);
        }
        
        var style = Style;
        if (Rotate != 0.0d)
        {
            if (string.IsNullOrEmpty(style))
                style = $"transform: {string.Format(StyleCons.Rotate, Rotate)}";
            else 
                style = $"{style}; transform: {string.Format(StyleCons.Rotate, Rotate)}";
        }

        var className = $"{Class} {CssProvider.GetClass()}";
        
        builder.OpenElement(0,"span");
        builder.AddAttribute(1,"role", "img");
        builder.AddAttribute(2,"aria-label", Label);
        builder.AddAttribute(3, "class", className);
        builder.AddAttribute(4, "onclick", OnClick);
        builder.AddAttribute(5, "onmousedown", OnMouseDown);
        builder.AddAttribute(6, "onmouseenter", onMouseEnter);
        builder.AddAttribute(7, "onmouseleave", onMouseLeave);
        builder.AddAttribute(8, "onmousemove", onMouseMove);
        builder.AddAttribute(9, "onmouseup", onMouseUp);
        builder.AddAttribute(10, "style", style);
        builder.AddContent(11, Svg);
        builder.CloseElement();
        base.BuildRenderTree(builder);
    }

    /// <summary>
    /// style
    /// </summary>
    private static class StyleCons
    {
        public const string PrefixCls = "semi-icon";
        public const string Default = $"{PrefixCls}-default";
        public const string Small = $"{PrefixCls}-small";
        public const string ExtraSmall = $"{PrefixCls}-extra-small";
        public const string Large = $"{PrefixCls}-large";
        public const string ExtraLarge = $"{PrefixCls}-extra-large";
        public const string Spinning = $"{PrefixCls}-spinning";
        public const string Rotate = "rotate({0}deg)";
    }

}

/// <summary>
/// icon size
/// </summary>
public enum IconSize: int
{
    Default = 0,    //// 16x16
    Inherit = 1,
    ExtraSmall = 2, // 8x8
    Small = 3,      // 12x12
    Large = 4,      // 20x20
    ExtraLarge = 5, // 24x24
}
