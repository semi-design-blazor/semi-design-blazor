namespace Semi.Design.Blazor;
public class SIconComment : SIcon
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
                d="M23 11.5C23 5.70101 18.299 1 12.5 1C6.70101 1 2 5.70101 2 11.5C2 13.4179 2.51422 15.2157 3.4123 16.7631L2.08689 20.7393C1.83512 21.4946 2.52398 22.2269 3.29323 22.0218L7.70712 20.8448C9.14399 21.5832 10.7733 22 12.5 22C18.299 22 23 17.299 23 11.5ZM7.5 13C6.67157 13 6 12.3284 6 11.5C6 10.6716 6.67157 10 7.5 10C8.32843 10 9 10.6716 9 11.5C9 12.3284 8.32843 13 7.5 13ZM14 11.5C14 12.3284 13.3284 13 12.5 13C11.6716 13 11 12.3284 11 11.5C11 10.6716 11.6716 10 12.5 10C13.3284 10 14 10.6716 14 11.5ZM17.5 13C16.6716 13 16 12.3284 16 11.5C16 10.6716 16.6716 10 17.5 10C18.3284 10 19 10.6716 19 11.5C19 12.3284 18.3284 13 17.5 13Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "comment";
        base.OnInitialized();
    }
}
