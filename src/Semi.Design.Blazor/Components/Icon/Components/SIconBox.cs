namespace Semi.Design.Blazor;
public class SIconBox : SIcon
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
                d="M2 6.00001L10.5542 1.29518C11.4545 0.800044 12.5455 0.800044 13.4458 1.29518L22 6.00001L12 11L2 6.00001Z"
                fill="currentColor"
            />
            <path
                d="M11 12.5L1 7.50001V16.1459C1 17.2822 1.64201 18.321 2.65836 18.8292L11 23V12.5Z"
                fill="currentColor"
            />
            <path
                d="M23 7.50001L13 12.5V23L21.3416 18.8292C22.358 18.321 23 17.2822 23 16.1459V7.50001Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "box";
        base.OnInitialized();
    }
}
