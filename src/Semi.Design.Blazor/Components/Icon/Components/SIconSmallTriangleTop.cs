namespace Semi.Design.Blazor;
public class SIconSmallTriangleTop : SIcon
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
                d="M17.0839 16.3212H6.9524C6.55305 16.3212 6.31486 15.8761 6.53638 15.5438L11.6021 7.94521C11.8 7.64834 12.2363 7.64834 12.4342 7.94521L17.4999 15.5438C17.7214 15.8761 17.4832 16.3212 17.0839 16.3212Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "small_triangle_top";
        base.OnInitialized();
    }
}
