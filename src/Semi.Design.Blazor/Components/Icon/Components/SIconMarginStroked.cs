namespace Semi.Design.Blazor;
public class SIconMarginStroked : SIcon
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
                d="M4 2C2.89543 2 2 2.89543 2 4V20C2 21.1046 2.89543 22 4 22H20C21.1046 22 22 21.1046 22 20V4C22 2.89543 21.1046 2 20 2H4ZM13 4H20V11H18C17.4477 11 17 11.4477 17 12C17 12.5523 17.4477 13 18 13H20V20H13V18C13 17.4477 12.5523 17 12 17C11.4477 17 11 17.4477 11 18V20H4V13H6C6.55228 13 7 12.5523 7 12C7 11.4477 6.55228 11 6 11H4L4 4L11 4V6C11 6.55228 11.4477 7 12 7C12.5523 7 13 6.55228 13 6V4ZM9 8C8.44772 8 8 8.44772 8 9V15C8 15.5523 8.44772 16 9 16H15C15.5523 16 16 15.5523 16 15V9C16 8.44772 15.5523 8 15 8H9ZM10 14V10H14V14H10Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "margin_stroked";
        base.OnInitialized();
    }
}
