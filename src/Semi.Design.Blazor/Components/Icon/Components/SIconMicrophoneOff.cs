namespace Semi.Design.Blazor;
public class SIconMicrophoneOff : SIcon
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
                d="M7.5 5.5C7.5 3.01472 9.51472 1 12 1C14.4853 1 16.5 3.01472 16.5 5.5V6.08579L20.2929 2.29289C20.6834 1.90237 21.3166 1.90237 21.7071 2.29289C22.0976 2.68342 22.0976 3.31658 21.7071 3.70711L3.70711 21.7071C3.31658 22.0976 2.68342 22.0976 2.29289 21.7071C1.90237 21.3166 1.90237 20.6834 2.29289 20.2929L5.90442 16.6814C4.71672 15.2855 4 13.4764 4 11.5C4 10.9477 4.44772 10.5 5 10.5C5.55228 10.5 6 10.9477 6 11.5C6 12.924 6.49606 14.2321 7.3248 15.261L8.39372 14.1921C7.8324 13.4413 7.5 12.5095 7.5 11.5V5.5Z"
                fill="currentColor"
            />
            <path d="M12 16L16.5 11.5C16.5 13.9853 14.4853 16 12 16Z" fill="currentColor" />
            <path
                d="M10.652 17.348L9.05822 18.9418C9.9688 19.302 10.9613 19.5 12 19.5C16.4183 19.5 20 15.9183 20 11.5C20 10.9477 19.5523 10.5 19 10.5C18.4477 10.5 18 10.9477 18 11.5C18 14.8137 15.3137 17.5 12 17.5C11.5365 17.5 11.0853 17.4474 10.652 17.348Z"
                fill="currentColor"
            />
            <path
                d="M8 21C7.44772 21 7 21.4477 7 22C7 22.5523 7.44772 23 8 23H16C16.5523 23 17 22.5523 17 22C17 21.4477 16.5523 21 16 21H8Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "microphone_off";
        base.OnInitialized();
    }
}
