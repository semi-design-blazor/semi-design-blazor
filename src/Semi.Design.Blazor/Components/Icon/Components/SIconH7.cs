namespace Semi.Design.Blazor;
public class SIconH7 : SIcon
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
                d="M3.5 2.5C4.32843 2.5 5 3.17157 5 4V10.5H11V4C11 3.17157 11.6716 2.5 12.5 2.5C13.3284 2.5 14 3.17157 14 4V20C14 20.8284 13.3284 21.5 12.5 21.5C11.6716 21.5 11 20.8284 11 20V13.5H5V20C5 20.8284 4.32843 21.5 3.5 21.5C2.67157 21.5 2 20.8284 2 20V4C2 3.17157 2.67157 2.5 3.5 2.5Z"
                fill="currentColor"
            />
            <path
                d="M16.793 19.8174C16.793 20.583 17.333 21.1025 18.1328 21.1025C18.6729 21.1025 19.0488 20.8428 19.3496 20.2754L22.1455 14.957C22.5762 14.1367 22.7334 13.624 22.7334 13.0088C22.7334 12.2158 22.1523 11.6689 21.3047 11.6689H16.6494C15.8496 11.6689 15.3438 12.1064 15.3438 12.79C15.3438 13.4668 15.8428 13.8838 16.6494 13.8838H19.835V13.9111L17.0186 19.0654C16.8682 19.3389 16.793 19.5918 16.793 19.8174Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "h7";
        base.OnInitialized();
    }
}
