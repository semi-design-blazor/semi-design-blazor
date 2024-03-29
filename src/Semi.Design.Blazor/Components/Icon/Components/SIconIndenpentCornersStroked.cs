namespace Semi.Design.Blazor;
public class SIconIndenpentCornersStroked : SIcon
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
                d="M15.5 2C14.9477 2 14.5 2.44772 14.5 3C14.5 3.55229 14.9477 4 15.5 4H20.5V9C20.5 9.55229 20.9477 10 21.5 10C22.0523 10 22.5 9.55229 22.5 9V3C22.5 2.44772 22.0523 2 21.5 2H15.5ZM9.5 22C10.0523 22 10.5 21.5523 10.5 21C10.5 20.4477 10.0523 20 9.5 20H4.5V15C4.5 14.4477 4.05228 14 3.5 14C2.94772 14 2.5 14.4477 2.5 15V21C2.5 21.5523 2.94772 22 3.5 22H9.5ZM3.5 10C2.94772 10 2.5 9.55228 2.5 9V3C2.5 2.44772 2.94772 2 3.5 2H9.5C10.0523 2 10.5 2.44771 10.5 3C10.5 3.55228 10.0523 4 9.5 4H4.5V9C4.5 9.55228 4.05229 10 3.5 10ZM22.5 15C22.5 14.4477 22.0523 14 21.5 14C20.9477 14 20.5 14.4477 20.5 15V20H15.5C14.9477 20 14.5 20.4477 14.5 21C14.5 21.5523 14.9477 22 15.5 22H21.5C22.0523 22 22.5 21.5523 22.5 21V15Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "indenpent_corners_stroked";
        base.OnInitialized();
    }
}
