namespace Semi.Design.Blazor;
public class SIconIndentRight : SIcon
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
                d="M1 4.5C1 3.67157 1.67157 3 2.5 3H13.5C14.3284 3 15 3.67157 15 4.5C15 5.32843 14.3284 6 13.5 6H2.5C1.67157 6 1 5.32843 1 4.5ZM1 9.5C1 8.67157 1.67157 8 2.5 8H13.5C14.3284 8 15 8.67157 15 9.5C15 10.3284 14.3284 11 13.5 11H2.5C1.67157 11 1 10.3284 1 9.5ZM2.5 13C1.67157 13 1 13.6716 1 14.5C1 15.3284 1.67157 16 2.5 16H13.5C14.3284 16 15 15.3284 15 14.5C15 13.6716 14.3284 13 13.5 13H2.5ZM1 19.5C1 18.6716 1.67157 18 2.5 18H13.5C14.3284 18 15 18.6716 15 19.5C15 20.3284 14.3284 21 13.5 21H2.5C1.67157 21 1 20.3284 1 19.5ZM16.9393 9.6213C16.3535 9.03552 16.3535 8.08577 16.9393 7.49998C17.5251 6.9142 18.4749 6.9142 19.0606 7.49998L22.5606 11C22.8419 11.2813 23 11.6628 23 12.0606C23 12.4585 22.8419 12.84 22.5606 13.1213L19.0606 16.6213C18.4749 17.2071 17.5251 17.2071 16.9393 16.6213C16.3535 16.0355 16.3535 15.0858 16.9393 14.5L19.3787 12.0606L16.9393 9.6213Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "indent_right";
        base.OnInitialized();
    }
}
