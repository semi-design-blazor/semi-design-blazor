namespace Semi.Design.Blazor;
public class SIconTemplateStroked : SIcon
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
                d="M3 3C3 1.89543 3.89543 1 5 1H19C20.1046 1 21 1.89543 21 3V21C21 22.1046 20.1046 23 19 23H5C3.89543 23 3 22.1046 3 21V3ZM19 3L5 3V21H19V3Z"
                fill="currentColor"
            />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M7 10C7 9.44772 7.44772 9 8 9H16C16.5523 9 17 9.44772 17 10V18C17 18.5523 16.5523 19 16 19H8C7.44772 19 7 18.5523 7 18V10ZM9 11V17H15V11H9Z"
                fill="currentColor"
            />
            <path
                d="M7 5.5C7 5.22386 7.22386 5 7.5 5H16.5C16.7761 5 17 5.22386 17 5.5V6.5C17 6.77614 16.7761 7 16.5 7H7.5C7.22386 7 7 6.77614 7 6.5V5.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "template_stroked";
        base.OnInitialized();
    }
}
