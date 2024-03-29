namespace Semi.Design.Blazor;
public class SIconServer : SIcon
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
                d="M2 4C2 2.89543 2.89543 2 4 2H20C21.1046 2 22 2.89543 22 4V9C22 10.1046 21.1046 11 20 11H4C2.89543 11 2 10.1046 2 9V4ZM8 6.5C8 5.67157 7.32843 5 6.5 5C5.67157 5 5 5.67157 5 6.5C5 7.32843 5.67157 8 6.5 8C7.32843 8 8 7.32843 8 6.5ZM2 15C2 13.8954 2.89543 13 4 13H20C21.1046 13 22 13.8954 22 15V20C22 21.1046 21.1046 22 20 22H4C2.89543 22 2 21.1046 2 20V15ZM8 17.5C8 16.6716 7.32843 16 6.5 16C5.67157 16 5 16.6716 5 17.5C5 18.3284 5.67157 19 6.5 19C7.32843 19 8 18.3284 8 17.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "server";
        base.OnInitialized();
    }
}
