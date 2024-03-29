namespace Semi.Design.Blazor;
public class SIconAlignHRightStroked : SIcon
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
                d="M20 3C20 2.44772 20.4477 2 21 2C21.5523 2 22 2.44772 22 3V21C22 21.5523 21.5523 22 21 22C20.4477 22 20 21.5523 20 21V3ZM3 6C3 5.44772 3.44772 5 4 5H17C17.5523 5 18 5.44772 18 6V10C18 10.5523 17.5523 11 17 11H4C3.44772 11 3 10.5523 3 10V6ZM5 7V9H16V7H5ZM9 13C8.44772 13 8 13.4477 8 14V18C8 18.5523 8.44772 19 9 19H17C17.5523 19 18 18.5523 18 18V14C18 13.4477 17.5523 13 17 13H9ZM10 17V15H16V17H10Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "align_h_right_stroked";
        base.OnInitialized();
    }
}
