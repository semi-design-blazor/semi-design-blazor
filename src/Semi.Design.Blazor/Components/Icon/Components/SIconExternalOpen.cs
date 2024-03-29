namespace Semi.Design.Blazor;
public class SIconExternalOpen : SIcon
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
                d="M12 3.5C12 2.67157 12.6716 2 13.5 2H19.5C20.8807 2 22 3.11929 22 4.5V10.5C22 11.3284 21.3284 12 20.5 12C19.6716 12 19 11.3284 19 10.5V7L11.0607 14.9394C10.4749 15.5251 9.52513 15.5251 8.93934 14.9394C8.35355 14.3536 8.35355 13.4038 8.93934 12.818L16.7574 5H13.5C12.6716 5 12 4.32843 12 3.5Z"
                fill="currentColor"
            />
            <path
                d="M5 8.5V18.5C5 18.7761 5.22386 19 5.5 19H15.5C15.7761 19 16 18.7761 16 18.5V15.5C16 14.6716 16.6716 14 17.5 14C18.3284 14 19 14.6716 19 15.5V18.5C19 20.433 17.433 22 15.5 22H5.5C3.567 22 2 20.433 2 18.5V8.5C2 6.567 3.567 5 5.5 5H8.5C9.32843 5 10 5.67157 10 6.5C10 7.32843 9.32843 8 8.5 8H5.5C5.22386 8 5 8.22386 5 8.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "external_open";
        base.OnInitialized();
    }
}
