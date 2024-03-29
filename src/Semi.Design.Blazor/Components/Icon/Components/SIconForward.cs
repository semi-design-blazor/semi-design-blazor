namespace Semi.Design.Blazor;
public class SIconForward : SIcon
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
                d="M22.7249 11.31L14.6525 2.81134C14.0331 2.15917 12.9388 2.59979 12.9388 3.50137V7.50289C5.97773 7.50289 2 12 2 17.9961C2 18.4958 2.2413 20.1767 2.5558 20.3122C2.69275 20.3713 2.8436 20.298 2.99443 19.9949C5.21806 15.5256 7.46938 15.4977 12.9388 15.4977V20.4986C12.9388 21.4002 14.0331 21.8408 14.6525 21.1887L22.7249 12.69C23.0917 12.3039 23.0917 11.6961 22.7249 11.31Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "forward";
        base.OnInitialized();
    }
}
