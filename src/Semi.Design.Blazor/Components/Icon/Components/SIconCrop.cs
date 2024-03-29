namespace Semi.Design.Blazor;
public class SIconCrop : SIcon
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
                d="M21.5 19C22.3284 19 23 18.3284 23 17.5C23 16.6716 22.3284 16 21.5 16H19V8C19 6.5 17.5 5 16 5H8V2.5C8 1.67157 7.32843 1 6.5 1C5.67157 1 5 1.67157 5 2.5V5H2.5C1.67157 5 1 5.67157 1 6.5C1 7.32843 1.67157 8 2.5 8L5 8V16C5 17.5 6.5 19 8 19H16V21.5C16 22.3284 16.6716 23 17.5 23C18.3284 23 19 22.3284 19 21.5V19H21.5ZM16 16V9C16 8.44772 15.5523 8 15 8L8 8V15C8 15.5523 8.44772 16 9 16L16 16Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "crop";
        base.OnInitialized();
    }
}
