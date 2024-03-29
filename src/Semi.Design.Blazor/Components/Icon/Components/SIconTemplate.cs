namespace Semi.Design.Blazor;
public class SIconTemplate : SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V5C22 3.34315 20.6569 2 19 2H5ZM6 5C5.44772 5 5 5.44772 5 6C5 6.55228 5.44772 7 6 7H18C18.5523 7 19 6.55228 19 6C19 5.44772 18.5523 5 18 5H6ZM5 10C5 9.44772 5.44772 9 6 9H10C10.5523 9 11 9.44772 11 10V18C11 18.5523 10.5523 19 10 19H6C5.44772 19 5 18.5523 5 18V10ZM14 9C13.4477 9 13 9.44772 13 10V15C13 15.5523 13.4477 16 14 16H18C18.5523 16 19 15.5523 19 15V10C19 9.44772 18.5523 9 18 9H14Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "template";
        base.OnInitialized();
    }
}
