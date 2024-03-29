namespace Semi.Design.Blazor;
public class SIconLeftCircleStroked : SIcon
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
                d="M2.5 12C2.5 7.02944 6.52944 3 11.5 3C16.4706 3 20.5 7.02944 20.5 12C20.5 16.9706 16.4706 21 11.5 21C6.52944 21 2.5 16.9706 2.5 12ZM11.5 1C5.42487 1 0.5 5.92487 0.5 12C0.5 18.0751 5.42487 23 11.5 23C17.5751 23 22.5 18.0751 22.5 12C22.5 5.92487 17.5751 1 11.5 1ZM13.7071 8.70711C14.0976 8.31658 14.0976 7.68342 13.7071 7.29289C13.3166 6.90237 12.6834 6.90237 12.2929 7.29289L8.40381 11.182C8.01328 11.5725 8.01328 12.2057 8.40381 12.5962L12.2929 16.4853C12.6834 16.8758 13.3166 16.8758 13.7071 16.4853C14.0976 16.0948 14.0976 15.4616 13.7071 15.0711L10.5251 11.8891L13.7071 8.70711Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "left_circle_stroked";
        base.OnInitialized();
    }
}
