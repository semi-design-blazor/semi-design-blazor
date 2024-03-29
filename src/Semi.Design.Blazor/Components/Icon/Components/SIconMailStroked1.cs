namespace Semi.Design.Blazor;
public class SIconMailStroked1 : SIcon
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
                d="M21 8.0412L13.3183 12.405C12.6314 12.7706 11.7962 12.7706 11.1093 12.405L3 7.79829L3 18H21V8.0412ZM4.29229 6L12.2138 10.5L20.1353 6H4.29229ZM1 6C1 4.89543 1.89543 4 3 4H21C22.1046 4 23 4.89543 23 6V6.90481L23.0001 6.90499L23 6.90505V18C23 19.1046 22.1046 20 21 20H3C1.89543 20 1 19.1046 1 18V6Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "mail_stroked1";
        base.OnInitialized();
    }
}
