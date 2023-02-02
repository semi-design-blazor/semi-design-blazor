namespace Semi.Design.Blazor;
public class SIconAlignVCenterStroked : SIcon
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
                d="M18 3C18.5523 3 19 3.44772 19 4V11H21C21.5523 11 22 11.4477 22 12C22 12.5523 21.5523 13 21 13H19V20C19 20.5523 18.5523 21 18 21H14C13.4477 21 13 20.5523 13 20V13H11V17C11 17.5523 10.5523 18 10 18H6C5.44771 18 5 17.5523 5 17L5 13H3C2.44772 13 2 12.5523 2 12C2 11.4477 2.44772 11 3 11H5V7C5 6.44772 5.44772 6 6 6L10 6C10.5523 6 11 6.44772 11 7V11H13V4C13 3.44772 13.4477 3 14 3H18ZM17 5L15 5V19H17L17 5ZM7 8H9L9 16H7V8Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "align_v_center_stroked";
        base.OnInitialized();
    }
}
