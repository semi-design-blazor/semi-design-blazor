namespace Semi.Design.Blazor;
public class SIconInnerSectionStroked : SIcon
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
                d="M5 2C4.44772 2 4 2.44772 4 3V21C4 21.5523 4.44772 22 5 22H10C10.5523 22 11 21.5523 11 21V3C11 2.44772 10.5523 2 10 2H5ZM6 20V4H9V20H6ZM14 2C13.4477 2 13 2.44772 13 3V21C13 21.5523 13.4477 22 14 22H19C19.5523 22 20 21.5523 20 21V3C20 2.44772 19.5523 2 19 2H14ZM15 20V4H18V20H15Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "inner_section_stroked";
        base.OnInitialized();
    }
}
