namespace Semi.Design.Blazor;
public class SIconExternalOpenStroked : SIcon
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
                d="M21 2C21.5523 2 22 2.44772 22 3V9C22 9.55229 21.5523 10 21 10C20.4477 10 20 9.55229 20 9V5.41421L10.7071 14.7071C10.3166 15.0976 9.68342 15.0976 9.29289 14.7071C8.90237 14.3166 8.90237 13.6834 9.29289 13.2929L18.5858 4L15 4C14.4477 4 14 3.55228 14 3C14 2.44772 14.4477 2 15 2H21ZM2 5C2 4.44772 2.44772 4 3 4H11C11.5523 4 12 4.44772 12 5C12 5.55229 11.5523 6 11 6H4V20H18V13C18 12.4477 18.4477 12 19 12C19.5523 12 20 12.4477 20 13V21C20 21.5523 19.5523 22 19 22H3C2.44772 22 2 21.5523 2 21V5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "external_open_stroked";
        base.OnInitialized();
    }
}
