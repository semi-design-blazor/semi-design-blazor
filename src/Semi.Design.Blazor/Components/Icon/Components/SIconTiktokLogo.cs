namespace Semi.Design.Blazor;
public class SIconTiktokLogo : SIcon
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
                d="M16.0727 1H12.2688V1.05774V8.27562H12.2688V16.1286H12.2666C12.206 17.8291 10.8109 19.189 9.0988 19.189C7.3481 19.189 5.92889 17.7671 5.92889 16.0131C5.92889 14.2591 7.3481 12.8373 9.0988 12.8373C9.46215 12.8373 9.81123 12.8985 10.1363 13.0113V9.10303C9.79781 9.05245 9.45136 9.02624 9.0988 9.02624C5.24727 9.02624 2.125 12.1544 2.125 16.0131C2.125 19.8719 5.24727 23 9.0988 23C12.9503 23 16.0726 19.8719 16.0726 16.0131H16.0727V8.47579C17.566 9.54917 19.3969 10.1811 21.375 10.1811V6.37008C18.4466 6.37008 16.0727 3.99166 16.0727 1.05774V1Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "tiktok_logo";
        base.OnInitialized();
    }
}
