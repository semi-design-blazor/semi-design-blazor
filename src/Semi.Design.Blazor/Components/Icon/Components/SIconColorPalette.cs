namespace Semi.Design.Blazor;
public class SIconColorPalette : SIcon
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
                d="M2 4C2 2.89543 2.89543 2 4 2H9C10.1046 2 11 2.89543 11 4V20C11 21.1046 10.1046 22 9 22H4C2.89543 22 2 21.1046 2 20V4ZM8 17.5C8 18.3284 7.32843 19 6.5 19C5.67157 19 5 18.3284 5 17.5C5 16.6716 5.67157 16 6.5 16C7.32843 16 8 16.6716 8 17.5ZM19.5858 8.58579L16.4142 5.41421C15.6332 4.63316 14.3668 4.63316 13.5858 5.41421L13 6V18L19.5858 11.4142C20.3668 10.6332 20.3668 9.36683 19.5858 8.58579ZM22 16C22 14.8954 21.1046 14 20 14L12 22H20C21.1046 22 22 21.1046 22 20V16Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "color_palette";
        base.OnInitialized();
    }
}
