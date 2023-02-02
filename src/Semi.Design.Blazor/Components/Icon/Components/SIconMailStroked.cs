namespace Semi.Design.Blazor;
public class SIconMailStroked : SIcon
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
                d="M3 4C1.89543 4 1 4.89543 1 6V18C1 19.1046 1.89543 20 3 20H21C22.1046 20 23 19.1046 23 18V6C23 4.89543 22.1046 4 21 4H3ZM3 7.23353V18H21V7.23353L12.5855 13.3107C12.236 13.5631 11.764 13.5631 11.4145 13.3107L3 7.23353ZM19.292 6H4.70797L12 11.2665L19.292 6Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "mail_stroked";
        base.OnInitialized();
    }
}
