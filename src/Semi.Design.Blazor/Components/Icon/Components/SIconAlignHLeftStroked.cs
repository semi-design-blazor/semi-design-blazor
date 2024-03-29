namespace Semi.Design.Blazor;
public class SIconAlignHLeftStroked : SIcon
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
                d="M2 3C2 2.44772 2.44772 2 3 2C3.55228 2 4 2.44772 4 3V21C4 21.5523 3.55228 22 3 22C2.44772 22 2 21.5523 2 21V3ZM6 6C6 5.44772 6.44772 5 7 5H20C20.5523 5 21 5.44772 21 6V10C21 10.5523 20.5523 11 20 11H7C6.44772 11 6 10.5523 6 10V6ZM8 7V9H19V7H8ZM7 13C6.44772 13 6 13.4477 6 14V18C6 18.5523 6.44772 19 7 19H15C15.5523 19 16 18.5523 16 18V14C16 13.4477 15.5523 13 15 13H7ZM8 17V15H14V17H8Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "align_h_left_stroked";
        base.OnInitialized();
    }
}
