namespace Semi.Design.Blazor;
public class SIconHash : SIcon
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
                d="M5.1 18L4.5032 20.1702C4.24999 21.0909 4.94281 22 5.89773 22C6.54881 22 7.11964 21.565 7.29227 20.9372L8.1 18H12.1L11.5032 20.1702C11.25 21.0909 11.9428 22 12.8977 22C13.5488 22 14.1196 21.565 14.2923 20.9372L15.1 18H19.5C20.3284 18 21 17.3284 21 16.5C21 15.6716 20.3284 15 19.5 15H15.925L17.575 9H20.5C21.3284 9 22 8.32843 22 7.5C22 6.67157 21.3284 6 20.5 6H18.4L18.9968 3.8298C19.25 2.90906 18.5572 2 17.6023 2C16.9512 2 16.3804 2.43504 16.2077 3.06281L15.4 6H11.4L11.9968 3.8298C12.25 2.90906 11.5572 2 10.6023 2C9.95119 2 9.38036 2.43504 9.20773 3.06281L8.4 6H4.5C3.67157 6 3 6.67157 3 7.5C3 8.32843 3.67157 9 4.5 9H7.575L5.925 15H3.5C2.67157 15 2 15.6716 2 16.5C2 17.3284 2.67157 18 3.5 18H5.1ZM8.925 15L10.575 9H14.575L12.925 15H8.925Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "hash";
        base.OnInitialized();
    }
}
