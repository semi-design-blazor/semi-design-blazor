namespace Semi.Design.Blazor;
public class SIconMapPin : SIcon
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
                d="M12 23C14 23 21 15.4183 21 10C21 4.58172 17.4183 1 12 1C6.58172 1 3 4.58172 3 10C3 15.4183 10 23 12 23ZM12 14C14.2091 14 16 12.2091 16 10C16 7.79086 14.2091 6 12 6C9.79086 6 8 7.79086 8 10C8 12.2091 9.79086 14 12 14Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "map_pin";
        base.OnInitialized();
    }
}
