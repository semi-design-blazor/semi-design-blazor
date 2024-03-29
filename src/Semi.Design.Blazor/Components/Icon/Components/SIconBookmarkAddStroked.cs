namespace Semi.Design.Blazor;
public class SIconBookmarkAddStroked : SIcon
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
                d="M6 3V19.7185L10.6251 17.3337C11.4878 16.8889 12.5123 16.8889 13.3749 17.3337L18 19.7185V3H6ZM5 1C4.44772 1 4 1.44772 4 2V21.3593C4 22.1081 4.79274 22.5912 5.45829 22.2481L11.5417 19.1113C11.8293 18.963 12.1708 18.963 12.4583 19.1113L18.5417 22.2481C19.2073 22.5912 20 22.1081 20 21.3593V2C20 1.44772 19.5523 1 19 1H5ZM8 10C8 9.44772 8.44772 9 9 9H11V7C11 6.44772 11.4477 6 12 6C12.5523 6 13 6.44772 13 7V9H15C15.5523 9 16 9.44772 16 10C16 10.5523 15.5523 11 15 11H13V13C13 13.5523 12.5523 14 12 14C11.4477 14 11 13.5523 11 13V11H9C8.44772 11 8 10.5523 8 10Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "bookmark_add_stroked";
        base.OnInitialized();
    }
}
