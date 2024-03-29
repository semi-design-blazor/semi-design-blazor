namespace Semi.Design.Blazor;
public class SIconAlignVBotStroked : SIcon
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
                d="M18.5 3C19.0523 3 19.5 3.44771 19.5 4V17C19.5 17.5523 19.0523 18 18.5 18H14.5C13.9477 18 13.5 17.5523 13.5 17V4C13.5 3.44772 13.9477 3 14.5 3H18.5ZM17.5 5H15.5V16H17.5V5ZM21.5 20C22.0523 20 22.5 20.4477 22.5 21C22.5 21.5523 22.0523 22 21.5 22H3.5C2.94772 22 2.5 21.5523 2.5 21C2.5 20.4477 2.94772 20 3.5 20H21.5ZM11.5 9C11.5 8.44772 11.0523 8 10.5 8H6.5C5.94772 8 5.5 8.44772 5.5 9V17C5.5 17.5523 5.94772 18 6.5 18H10.5C11.0523 18 11.5 17.5523 11.5 17V9ZM7.5 10H9.5V16H7.5V10Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "align_v_bot_stroked";
        base.OnInitialized();
    }
}
