namespace Semi.Design.Blazor;
public class SIconUserCardVideo : SIcon
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
                d="M3 4C1.89543 4 1 4.89543 1 6V18C1 19.1046 1.89543 20 3 20H14C15.1046 20 16 19.1046 16 18V6C16 4.89543 15.1046 4 14 4H3ZM7.9823 8H4.9823V11H7.9823V8Z"
                fill="currentColor"
            />
            <path
                d="M21.5526 6.72418C22.2176 6.39151 23.0001 6.875 23.0001 7.6185V16.3815C23.0001 17.125 22.2176 17.6085 21.5526 17.2758L17.5565 15.2765C17.2178 15.107 17.0039 14.7608 17.0039 14.3821V12V9.61786C17.0039 9.23918 17.2178 8.89298 17.5565 8.72354L21.5526 6.72418Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "user_card_video";
        base.OnInitialized();
    }
}
