namespace Semi.Design.Blazor;
public class SIconSectionStroked : SIcon
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
                d="M3 4C2.44772 4 2 4.44772 2 5V10C2 10.5523 2.44772 11 3 11H21C21.5523 11 22 10.5523 22 10V5C22 4.44772 21.5523 4 21 4H3ZM4 9V6H20V9H4ZM3 13C2.44772 13 2 13.4477 2 14V19C2 19.5523 2.44772 20 3 20H21C21.5523 20 22 19.5523 22 19V14C22 13.4477 21.5523 13 21 13H3ZM4 18V15H20V18H4Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "section_stroked";
        base.OnInitialized();
    }
}
