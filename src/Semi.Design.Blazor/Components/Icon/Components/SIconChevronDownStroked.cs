namespace Semi.Design.Blazor;
public class SIconChevronDownStroked : SIcon
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
                d="M4.08401 8.14944C4.55377 7.64355 5.34468 7.61426 5.85057 8.08401L12 13.7942L18.1494 8.08401C18.6553 7.61426 19.4462 7.64355 19.916 8.14944C20.3857 8.65533 20.3565 9.44624 19.8506 9.916L12.8506 16.416C12.371 16.8613 11.629 16.8613 11.1494 16.416L4.14944 9.916C3.64355 9.44624 3.61426 8.65533 4.08401 8.14944Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "chevron_down_stroked";
        base.OnInitialized();
    }
}
