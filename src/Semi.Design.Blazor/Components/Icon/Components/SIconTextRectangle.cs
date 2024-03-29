namespace Semi.Design.Blazor;
public class SIconTextRectangle : SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V5C22 3.34315 20.6569 2 19 2H5ZM7 6H17C17.5523 6 18 6.44772 18 7V9C18 9.55228 17.5523 10 17 10C16.4477 10 16 9.55228 16 9V8H13V16H14C14.5523 16 15 16.4477 15 17C15 17.5523 14.5523 18 14 18H13H11H10C9.44772 18 9 17.5523 9 17C9 16.4477 9.44772 16 10 16H11V8H8V9C8 9.55228 7.55228 10 7 10C6.44772 10 6 9.55228 6 9V7C6 6.44772 6.44772 6 7 6Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "text_rectangle";
        base.OnInitialized();
    }
}
