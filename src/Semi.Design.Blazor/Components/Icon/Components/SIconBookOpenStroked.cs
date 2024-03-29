namespace Semi.Design.Blazor;
public class SIconBookOpenStroked : SIcon
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
                d="M2 2.5C1.44772 2.5 1 2.94772 1 3.5V18.5C1 19.0523 1.44772 19.5 2 19.5H9C10.1046 19.5 11 20.3954 11 21.5C11 22.0523 11.4477 22.5 12 22.5C12.5523 22.5 13 22.0523 13 21.5C13 20.3954 13.8954 19.5 15 19.5H22C22.5523 19.5 23 19.0523 23 18.5V3.5C23 2.94772 22.5523 2.5 22 2.5H16C14.3644 2.5 12.9122 3.28534 12 4.49951C11.0878 3.28534 9.6356 2.5 8 2.5H2ZM11 7.5C11 5.84313 9.65687 4.5 8 4.5H3V17.5H9C9.72857 17.5 10.4117 17.6948 11 18.0351V7.5ZM13 18.0351C13.5883 17.6948 14.2714 17.5 15 17.5H21V4.5H16C14.3431 4.5 13 5.84313 13 7.5V18.0351Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "book_open_stroked";
        base.OnInitialized();
    }
}
