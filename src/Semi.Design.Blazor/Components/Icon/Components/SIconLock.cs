namespace Semi.Design.Blazor;
public class SIconLock : SIcon
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
                d="M12 2C8.41015 2 5.5 4.91015 5.5 8.5V10H5C3.89543 10 3 10.8954 3 12V20C3 21.1046 3.89543 22 5 22H19C20.1046 22 21 21.1046 21 20V12C21 10.8954 20.1046 10 19 10H18.5V8.5C18.5 4.91015 15.5899 2 12 2ZM15.5 10V8.5C15.5 6.567 13.933 5 12 5C10.067 5 8.5 6.567 8.5 8.5V10H15.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "lock";
        base.OnInitialized();
    }
}
