namespace Semi.Design.Blazor;
public class SIconShoppingBag : SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V5C22 3.34315 20.6569 2 19 2H5ZM7 6C7 5.44772 6.55228 5 6 5C5.44772 5 5 5.44772 5 6C5 9.86599 8.13401 13 12 13C15.866 13 19 9.86599 19 6C19 5.44772 18.5523 5 18 5C17.4477 5 17 5.44772 17 6C17 8.76142 14.7614 11 12 11C9.23858 11 7 8.76142 7 6Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "shopping_bag";
        base.OnInitialized();
    }
}
