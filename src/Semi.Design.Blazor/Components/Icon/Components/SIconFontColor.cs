namespace Semi.Design.Blazor;
public class SIconFontColor : SIcon
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
                d="M13.3523 1.88455C13.1026 1.36447 12.5769 1.03364 12 1.03364C11.4231 1.03364 10.8974 1.36447 10.6477 1.88455L4.6477 14.8509C4.28921 15.5977 4.60404 16.4937 5.35088 16.8522C6.09773 17.2107 6.99378 16.8959 7.35226 16.149L8.62383 13.4999H15.3761L16.6477 16.149C17.0062 16.8959 17.9022 17.2107 18.6491 16.8522C19.3959 16.4937 19.7108 15.5977 19.3523 14.8509L13.3523 1.88455ZM12 6L13.9361 10.4999H10.0638L12 6ZM3 17.9999C2.44772 17.9999 2 18.4477 2 18.9999V20.9999C2 21.5522 2.44772 21.9999 3 21.9999H21C21.5523 21.9999 22 21.5522 22 20.9999V18.9999C22 18.4477 21.5523 17.9999 21 17.9999H3Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "font_color";
        base.OnInitialized();
    }
}
