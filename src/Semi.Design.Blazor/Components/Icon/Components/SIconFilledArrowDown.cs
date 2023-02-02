namespace Semi.Design.Blazor;
public class SIconFilledArrowDown : SIcon
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
                d="M22.1464 12.0606L12.3535 21.8535C12.1582 22.0488 11.8417 22.0488 11.6464 21.8535L1.8535 12.0606C1.53852 11.7457 1.7616 11.2071 2.20706 11.2071H7.99995V2.20709C7.99995 1.65481 8.44767 1.20709 8.99995 1.20709H15C15.5522 1.20709 16 1.65481 16 2.20709V11.2071H21.7928C22.2383 11.2071 22.4614 11.7457 22.1464 12.0606Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "filled_arrow_down";
        base.OnInitialized();
    }
}
