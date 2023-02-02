namespace Semi.Design.Blazor;
public class SIconSmallTriangleRight : SIcon
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
                d="M9 17.0657V6.93425C9 6.5349 9.44507 6.29671 9.77735 6.51823L17.376 11.584C17.6728 11.7819 17.6728 12.2181 17.376 12.416L9.77735 17.4818C9.44507 17.7033 9 17.4651 9 17.0657Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "small_triangle_right";
        base.OnInitialized();
    }
}
