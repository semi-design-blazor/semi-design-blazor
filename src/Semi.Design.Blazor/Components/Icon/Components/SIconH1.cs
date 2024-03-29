namespace Semi.Design.Blazor;
public class SIconH1 : SIcon
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
                d="M3.5 2.5C4.32843 2.5 5 3.17157 5 4V10.5H11V4C11 3.17157 11.6716 2.5 12.5 2.5C13.3284 2.5 14 3.17157 14 4V20C14 20.8284 13.3284 21.5 12.5 21.5C11.6716 21.5 11 20.8284 11 20V13.5H5V20C5 20.8284 4.32843 21.5 3.5 21.5C2.67157 21.5 2 20.8284 2 20V4C2 3.17157 2.67157 2.5 3.5 2.5Z"
                fill="currentColor"
            />
            <path
                d="M19.4316 19.585C19.4316 20.5557 19.9443 21.1025 20.8604 21.1025C21.7695 21.1025 22.2754 20.5625 22.2754 19.585V13.3096C22.2754 12.2705 21.6191 11.6006 20.6074 11.6006C20.04 11.6006 19.4111 11.792 18.8232 12.1475L17.8594 12.7285C17.3809 13.0156 17.1348 13.3779 17.1348 13.7949C17.1348 14.3555 17.5312 14.752 18.0918 14.752C18.3652 14.752 18.584 14.6699 19.0352 14.4033L19.418 14.1777H19.4316V19.585Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "h1";
        base.OnInitialized();
    }
}
