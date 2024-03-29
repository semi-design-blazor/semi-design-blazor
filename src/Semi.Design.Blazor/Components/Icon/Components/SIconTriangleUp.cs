namespace Semi.Design.Blazor;
public class SIconTriangleUp : SIcon
{
    protected override void OnInitialized()
    {
        Svg = builder =>
        {
            builder.OpenElement(0, "svg");
            builder.AddAttribute(1, "viewBox", "0 0 24 24");
            builder.AddAttribute(2, "fill", "none");
            builder.AddAttribute(3, "xmlns", "http://www.w3.org/2000/svg");
            builder.AddAttribute(4, "width", "1em");
            builder.AddAttribute(5, "height", "1em");
            builder.AddAttribute(6, "focusable", "false");
            builder.AddAttribute(7, "aria-hidden", "true");
            builder.AddMarkupContent(8, """
            <path
                d="M2.16707 17.4086L11.1937 5.09962C11.5932 4.55477 12.4069 4.55477 12.8065 5.09962L21.8331 17.4086C22.3175 18.0691 21.8458 19 21.0267 19H2.97347C2.15437 19 1.68268 18.0691 2.16707 17.4086Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "triangle_up";
        base.OnInitialized();
    }
}
