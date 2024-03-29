namespace Semi.Design.Blazor;
public class SIconUnlockStroked : SIcon
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
                d="M12 3C10.3431 3 9 4.34315 9 6V8H18C19.1046 8 20 8.89543 20 10V20C20 21.1046 19.1046 22 18 22H6C4.89543 22 4 21.1046 4 20V10C4 8.89543 4.89543 8 6 8H7V6C7 3.23858 9.23858 1 12 1C14.7614 1 17 3.23858 17 6H15C15 4.34315 13.6569 3 12 3ZM6 20H18V10H6V20ZM14 15C14 16.1046 13.1046 17 12 17C10.8954 17 10 16.1046 10 15C10 13.8954 10.8954 13 12 13C13.1046 13 14 13.8954 14 15Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "unlock_stroked";
        base.OnInitialized();
    }
}
