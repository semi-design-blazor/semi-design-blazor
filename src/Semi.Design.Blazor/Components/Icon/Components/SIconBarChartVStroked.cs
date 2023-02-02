namespace Semi.Design.Blazor;
public class SIconBarChartVStroked : SIcon
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
                d="M9 3C9 2.44772 9.44772 2 10 2H14C14.5523 2 15 2.44772 15 3V21C15 21.5523 14.5523 22 14 22H10C9.44772 22 9 21.5523 9 21V3ZM11 4V20H13V4H11ZM2 8C2 7.44772 2.44772 7 3 7H7C7.55228 7 8 7.44772 8 8V21C8 21.5523 7.55228 22 7 22H3C2.44772 22 2 21.5523 2 21V8ZM4 9V20H6V9H4ZM17 10C16.4477 10 16 10.4477 16 11V21C16 21.5523 16.4477 22 17 22H21C21.5523 22 22 21.5523 22 21V11C22 10.4477 21.5523 10 21 10H17ZM18 20V12H20V20H18Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "bar_chart_v_stroked";
        base.OnInitialized();
    }
}
