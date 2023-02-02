namespace Semi.Design.Blazor;
public class SIconVoteStroked : SIcon
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
                d="M5 4.5C5 3.67157 5.67157 3 6.5 3H17.5C18.3284 3 19 3.67157 19 4.5V15.5C19 16.3284 18.3284 17 17.5 17H6.5C5.67157 17 5 16.3284 5 15.5V4.5ZM7 5V15H17V5H7ZM5 19.5C5 19.2239 5.22386 19 5.5 19H18.5C18.7761 19 19 19.2239 19 19.5V20.5C19 20.7761 18.7761 21 18.5 21H5.5C5.22386 21 5 20.7761 5 20.5V19.5ZM2 14C1.44772 14 1 14.4477 1 15V20.5C1 20.7761 1.22386 21 1.5 21H2.5C2.77614 21 3 20.7761 3 20.5V16H3.5C3.77614 16 4 15.7761 4 15.5V14.5C4 14.2239 3.77614 14 3.5 14H2ZM21 16H20.5C20.2239 16 20 15.7761 20 15.5V14.5C20 14.2239 20.2239 14 20.5 14H22C22.5523 14 23 14.4477 23 15V20.5C23 20.7761 22.7761 21 22.5 21H21.5C21.2239 21 21 20.7761 21 20.5V16ZM15.7071 8.70711C16.0976 8.31658 16.0976 7.68342 15.7071 7.29289C15.3166 6.90237 14.6834 6.90237 14.2929 7.29289L11 10.5858L9.70711 9.29289C9.31658 8.90237 8.68342 8.90237 8.29289 9.29289C7.90237 9.68342 7.90237 10.3166 8.29289 10.7071L10.2929 12.7071C10.6834 13.0976 11.3166 13.0976 11.7071 12.7071L15.7071 8.70711Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "vote_stroked";
        base.OnInitialized();
    }
}
