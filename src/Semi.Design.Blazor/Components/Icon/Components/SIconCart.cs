namespace Semi.Design.Blazor;
public class SIconCart : SIcon
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
                d="M0.5 4C0.5 3.17157 1.17157 2.5 2 2.5H5C5.74036 2.5 6.36998 3.04017 6.48256 3.77191L6.67149 5H21.7534C22.3931 5 22.8684 5.59242 22.7296 6.21693L21.174 13.2169C21.0723 13.6745 20.6665 14 20.1978 14H8.05611L8.28688 15.5H19C19.8284 15.5 20.5 16.1716 20.5 17C20.5 17.8284 19.8284 18.5 19 18.5H7C6.25964 18.5 5.63002 17.9598 5.51744 17.2281L3.71312 5.5H2C1.17157 5.5 0.5 4.82843 0.5 4ZM9 23C10.1046 23 11 22.1046 11 21C11 19.8954 10.1046 19 9 19C7.89543 19 7 19.8954 7 21C7 22.1046 7.89543 23 9 23ZM18 23C19.1046 23 20 22.1046 20 21C20 19.8954 19.1046 19 18 19C16.8954 19 16 19.8954 16 21C16 22.1046 16.8954 23 18 23Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "cart";
        base.OnInitialized();
    }
}
