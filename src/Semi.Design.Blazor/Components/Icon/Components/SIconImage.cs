namespace Semi.Design.Blazor;
public class SIconImage : SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V5C22 3.34315 20.6569 2 19 2H5ZM10 7.5C10 8.88071 8.88071 10 7.5 10C6.11929 10 5 8.88071 5 7.5C5 6.11929 6.11929 5 7.5 5C8.88071 5 10 6.11929 10 7.5ZM16.7071 11.7071C16.3166 11.3166 15.6834 11.3166 15.2929 11.7071L11 16L9.70711 14.7071C9.31658 14.3166 8.68342 14.3166 8.29289 14.7071L5 18V19H8H12H19V14L16.7071 11.7071Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "image";
        base.OnInitialized();
    }
}
