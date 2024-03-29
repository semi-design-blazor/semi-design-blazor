namespace Semi.Design.Blazor;
public class SIconGridView1 : SIcon
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
                d="M2 4C1.44772 4 1 4.44772 1 5V10C1 10.5523 1.44772 11 2 11H6C6.55228 11 7 10.5523 7 10V5C7 4.44772 6.55228 4 6 4H2ZM2 13C1.44772 13 1 13.4477 1 14V19C1 19.5523 1.44772 20 2 20H6C6.55228 20 7 19.5523 7 19V14C7 13.4477 6.55228 13 6 13H2ZM9 5C9 4.44772 9.44772 4 10 4H14C14.5523 4 15 4.44772 15 5V10C15 10.5523 14.5523 11 14 11H10C9.44772 11 9 10.5523 9 10V5ZM18 4C17.4477 4 17 4.44772 17 5V10C17 10.5523 17.4477 11 18 11H22C22.5523 11 23 10.5523 23 10V5C23 4.44772 22.5523 4 22 4H18ZM9 14C9 13.4477 9.44772 13 10 13H14C14.5523 13 15 13.4477 15 14V19C15 19.5523 14.5523 20 14 20H10C9.44772 20 9 19.5523 9 19V14ZM18 13C17.4477 13 17 13.4477 17 14V19C17 19.5523 17.4477 20 18 20H22C22.5523 20 23 19.5523 23 19V14C23 13.4477 22.5523 13 22 13H18Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "grid_view1";
        base.OnInitialized();
    }
}
