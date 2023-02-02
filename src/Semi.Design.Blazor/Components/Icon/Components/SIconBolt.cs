namespace Semi.Design.Blazor;
public class SIconBolt : SIcon
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
                d="M3.60005 14.2L15.1026 0.650275C15.4063 0.245303 16.0505 0.496326 16.0001 1.00003L14.0001 9H20.0001C20.4121 9 20.6473 9.47038 20.4001 9.8L8.89764 23.3498C8.59391 23.7547 7.94975 23.5037 8.00012 23L10.0001 15H4.00005C3.58803 15 3.35284 14.5296 3.60005 14.2Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "bolt";
        base.OnInitialized();
    }
}
