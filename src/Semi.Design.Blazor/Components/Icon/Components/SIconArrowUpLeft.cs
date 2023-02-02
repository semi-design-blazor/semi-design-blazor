namespace Semi.Design.Blazor;
public class SIconArrowUpLeft : SIcon
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
                d="M3.5 18C2.67157 18 2 17.3284 2 16.5L2 3.5C2 2.67157 2.67157 2 3.5 2H16.5C17.3284 2 18 2.67157 18 3.5C18 4.32843 17.3284 5 16.5 5H7.12132L20.5606 18.4393C21.1464 19.0251 21.1464 19.9749 20.5606 20.5607C19.9749 21.1464 19.0251 21.1464 18.4393 20.5607L5 7.12132L5 16.5C5 17.3284 4.32843 18 3.5 18Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "arrow_up_left";
        base.OnInitialized();
    }
}
