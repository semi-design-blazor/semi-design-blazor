namespace Semi.Design.Blazor;
public class SIconSmartphoneStroked : SIcon
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
                d="M6.5 1C5.39543 1 4.5 1.89543 4.5 3V21C4.5 22.1046 5.39543 23 6.5 23H17.5C18.6046 23 19.5 22.1046 19.5 21V3C19.5 1.89543 18.6046 1 17.5 1H6.5ZM6.5 3L17.5 3V21H6.5V3ZM9 19C9 18.4477 9.44772 18 10 18H14C14.5523 18 15 18.4477 15 19C15 19.5523 14.5523 20 14 20H10C9.44772 20 9 19.5523 9 19Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "smartphone_stroked";
        base.OnInitialized();
    }
}
