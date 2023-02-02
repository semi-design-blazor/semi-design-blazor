namespace Semi.Design.Blazor;
public class SIconOption : SIcon
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
                d="M3.5 3.5C2.67157 3.5 2 4.17157 2 5C2 5.82843 2.67157 6.5 3.5 6.5H7.12952L14.6976 19.7442C14.9647 20.2116 15.4617 20.5 16 20.5H20.5C21.3284 20.5 22 19.8284 22 19C22 18.1716 21.3284 17.5 20.5 17.5H16.8705L9.30236 4.25579C9.0353 3.78843 8.53829 3.5 8 3.5H3.5ZM14.5 3.5C13.6716 3.5 13 4.17157 13 5C13 5.82843 13.6716 6.5 14.5 6.5H20.5C21.3284 6.5 22 5.82843 22 5C22 4.17157 21.3284 3.5 20.5 3.5H14.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "option";
        base.OnInitialized();
    }
}
