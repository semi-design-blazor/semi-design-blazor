namespace Semi.Design.Blazor;
public class SIconArrowUp : SIcon
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
                d="M12 23C11.1716 23 10.5 22.3284 10.5 21.5L10.5 6.12132L4.06066 12.5607C3.47487 13.1464 2.52513 13.1464 1.93934 12.5607C1.35355 11.9749 1.35355 11.0251 1.93934 10.4393L10.9393 1.43934C11.5251 0.853554 12.4749 0.853554 13.0607 1.43934L22.0607 10.4393C22.6464 11.0251 22.6464 11.9749 22.0607 12.5607C21.4749 13.1464 20.5251 13.1464 19.9393 12.5607L13.5 6.12132L13.5 21.5C13.5 22.3284 12.8284 23 12 23Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "arrow_up";
        base.OnInitialized();
    }
}
