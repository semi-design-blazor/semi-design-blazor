namespace Semi.Design.Blazor;
public class SIconInheritStroked : SIcon
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
                d="M2 4.5C2 3.67157 2.67157 3 3.5 3H20.5C21.3284 3 22 3.67157 22 4.5V9.5C22 10.3284 21.3284 11 20.5 11H9V16H14V14.5C14 13.6716 14.6716 13 15.5 13H20.5C21.3284 13 22 13.6716 22 14.5V19.5C22 20.3284 21.3284 21 20.5 21H15.5C14.6716 21 14 20.3284 14 19.5V18H8C7.44772 18 7 17.5523 7 17V11H3.5C2.67157 11 2 10.3284 2 9.5V4.5ZM7 9H9H20V5H4V9H7ZM20 15H16V19H20V15Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "inherit_stroked";
        base.OnInitialized();
    }
}
