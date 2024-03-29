namespace Semi.Design.Blazor;
public class SIconCandlestickChartStroked : SIcon
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
                d="M5 2C5.55228 2 6 2.44772 6 3V9H7C7.55228 9 8 9.44772 8 10V18C8 18.5523 7.55228 19 7 19H6V21C6 21.5523 5.55228 22 5 22C4.44772 22 4 21.5523 4 21V19H3C2.44772 19 2 18.5523 2 18V10C2 9.44772 2.44772 9 3 9H4V3C4 2.44772 4.44772 2 5 2ZM5 17H6V11H4V17H5ZM16 8C16 7.44772 16.4477 7 17 7H18V3C18 2.44772 18.4477 2 19 2C19.5523 2 20 2.44772 20 3V7H21C21.5523 7 22 7.44772 22 8V16C22 16.5523 21.5523 17 21 17H20V21C20 21.5523 19.5523 22 19 22C18.4477 22 18 21.5523 18 21V17H17C16.4477 17 16 16.5523 16 16V8ZM20 15H19H18V9H19H20V15ZM10 5C9.44772 5 9 5.44772 9 6V14C9 14.5523 9.44772 15 10 15H11V21C11 21.5523 11.4477 22 12 22C12.5523 22 13 21.5523 13 21V15H14C14.5523 15 15 14.5523 15 14V6C15 5.44772 14.5523 5 14 5H13V3C13 2.44772 12.5523 2 12 2C11.4477 2 11 2.44772 11 3V5H10ZM12 13H11V7H12H13V13H12Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "candlestick_chart_stroked";
        base.OnInitialized();
    }
}
