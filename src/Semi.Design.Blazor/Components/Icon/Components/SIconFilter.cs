namespace Semi.Design.Blazor;
public class SIconFilter : SIcon
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
                d="M1.0929 2.57912C1.25675 2.22596 1.61069 2 2.00001 2H22C22.3893 2 22.7433 2.22596 22.9071 2.57912C23.071 2.93229 23.015 3.34845 22.7636 3.64573L14.5654 12.8261V21C14.5654 21.3466 14.386 21.6684 14.0911 21.8507C13.7963 22.0329 13.4282 22.0494 13.1182 21.8944L10.0528 19.8944C9.71401 19.725 9.5 19.3788 9.5 19V12.8261L1.23644 3.64573C0.985045 3.34845 0.929036 2.93229 1.0929 2.57912Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "filter";
        base.OnInitialized();
    }
}
