namespace Semi.Design.Blazor;
public class SIconMusic : SIcon
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
                d="M8.29409 2.39818C7.65103 2.20032 7 2.68115 7 3.35396V11.3368C6.54537 11.1208 6.0368 11 5.5 11C3.567 11 2 12.567 2 14.5C2 16.433 3.567 18 5.5 18C7.433 18 9 16.433 9 14.5V5L18 7.76923V15.3368C17.5454 15.1208 17.0368 15 16.5 15C14.567 15 13 16.567 13 18.5C13 20.433 14.567 22 16.5 22C18.433 22 20 20.433 20 18.5V6.73858C20 6.29957 19.7137 5.9119 19.2941 5.7828L8.29409 2.39818Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "music";
        base.OnInitialized();
    }
}
