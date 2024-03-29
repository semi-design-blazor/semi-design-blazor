namespace Semi.Design.Blazor;
public class SIconGallery : SIcon
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
            <rect x={5} y={9} width={18} height={14} rx={3} fill="currentColor" />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M15.659 0.747655L2.46269 4.22036C0.836568 4.64829 -0.120338 6.32896 0.3416 7.94575L2.69291 16.1753C2.76592 16.4309 2.87002 16.6693 2.99997 16.8876V11C2.99997 8.79088 4.79083 7.00002 6.99997 7.00002H20.5L19.307 2.82472C18.8586 1.25519 17.2376 0.332237 15.659 0.747655Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "gallery";
        base.OnInitialized();
    }
}
