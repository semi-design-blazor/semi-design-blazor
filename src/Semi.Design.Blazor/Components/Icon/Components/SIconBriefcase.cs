namespace Semi.Design.Blazor;
public class SIconBriefcase : SIcon
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
                d="M7 3C7 1.89543 7.89543 1 9 1H15C16.1046 1 17 1.89543 17 3V6H20H21C22.1046 6 23 6.89543 23 8V9V11H1V9V8C1 6.89543 1.89543 6 3 6H4H7V3ZM9 6H15V3.5C15 3.22386 14.7761 3 14.5 3H9.5C9.22386 3 9 3.22386 9 3.5V6ZM15 13.5C15 13.2239 15.2239 13 15.5 13H23V19V20C23 21.1046 22.1046 22 21 22H20H4H3C1.89543 22 1 21.1046 1 20V19V13H8.5C8.77614 13 9 13.2239 9 13.5V15C9 15.5523 9.44772 16 10 16H14C14.5523 16 15 15.5523 15 15V13.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "briefcase";
        base.OnInitialized();
    }
}
