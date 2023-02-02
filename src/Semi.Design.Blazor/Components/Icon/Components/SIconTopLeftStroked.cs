namespace Semi.Design.Blazor;
public class SIconTopLeftStroked : SIcon
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
                fillRule="evenodd"
                clipRule="evenodd"
                d="M3 2C2.44772 2 2 2.44772 2 3V21C2 21.5523 2.44772 22 3 22C3.55228 22 4 21.5523 4 21V4H21C21.5523 4 22 3.55228 22 3C22 2.44772 21.5523 2 21 2H3ZM11 10C10.4477 10 10 10.4477 10 11V21C10 21.5523 10.4477 22 11 22H21C21.5523 22 22 21.5523 22 21V11C22 10.4477 21.5523 10 21 10H11ZM12 20V12H20V20H12Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "top_left_stroked";
        base.OnInitialized();
    }
}
