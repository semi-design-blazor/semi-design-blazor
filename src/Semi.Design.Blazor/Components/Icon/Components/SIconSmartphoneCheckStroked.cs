namespace Semi.Design.Blazor;
public class SIconSmartphoneCheckStroked : SIcon
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
                d="M4.5 3C4.5 1.89543 5.39543 1 6.5 1H17.5C18.6046 1 19.5 1.89543 19.5 3V21C19.5 22.1046 18.6046 23 17.5 23H6.5C5.39543 23 4.5 22.1046 4.5 21V3ZM17.5 3L6.5 3V21H17.5V3ZM10 18C9.44772 18 9 18.4477 9 19C9 19.5523 9.44772 20 10 20H14C14.5523 20 15 19.5523 15 19C15 18.4477 14.5523 18 14 18H10ZM14.7682 9.64021C15.1218 9.21593 15.0645 8.58537 14.6402 8.2318C14.2159 7.87824 13.5853 7.93556 13.2318 8.35984L11.4328 10.5186L10.7071 9.79292C10.3166 9.40239 9.68342 9.40239 9.29289 9.79292C8.90237 10.1834 8.90237 10.8166 9.29289 11.2071L10.7929 12.7071C10.9916 12.9058 11.2646 13.0117 11.5453 12.999C11.826 12.9863 12.0884 12.856 12.2682 12.6402L14.7682 9.64021Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "smartphone_check_stroked";
        base.OnInitialized();
    }
}
