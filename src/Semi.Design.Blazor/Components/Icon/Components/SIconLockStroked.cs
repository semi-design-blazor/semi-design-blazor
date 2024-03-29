namespace Semi.Design.Blazor;
public class SIconLockStroked : SIcon
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
                d="M12 2C9.23858 2 7 4.23858 7 7V8H6C4.89543 8 4 8.89543 4 10V20C4 21.1046 4.89543 22 6 22H18C19.1046 22 20 21.1046 20 20V10C20 8.89543 19.1046 8 18 8H17V7C17 4.23858 14.7614 2 12 2ZM15 8V7C15 5.34315 13.6569 4 12 4C10.3431 4 9 5.34315 9 7V8H15ZM7 10H6V20H18V10H17H7ZM12 17C13.1046 17 14 16.1046 14 15C14 13.8954 13.1046 13 12 13C10.8954 13 10 13.8954 10 15C10 16.1046 10.8954 17 12 17Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "lock_stroked";
        base.OnInitialized();
    }
}
