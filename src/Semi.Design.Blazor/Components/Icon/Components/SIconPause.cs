namespace Semi.Design.Blazor;
public class SIconPause : SIcon
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
                d="M4.5 4.75C4.5 3.23122 5.73122 2 7.25 2C8.76878 2 10 3.23122 10 4.75V19.25C10 20.7688 8.76878 22 7.25 22C5.73122 22 4.5 20.7688 4.5 19.25V4.75Z"
                fill="currentColor"
            />
            <path
                d="M14 4.75C14 3.23122 15.2312 2 16.75 2C18.2688 2 19.5 3.23122 19.5 4.75V19.25C19.5 20.7688 18.2688 22 16.75 22C15.2312 22 14 20.7688 14 19.25V4.75Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "pause";
        base.OnInitialized();
    }
}
