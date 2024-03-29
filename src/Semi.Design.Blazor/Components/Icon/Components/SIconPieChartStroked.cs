namespace Semi.Design.Blazor;
public class SIconPieChartStroked : SIcon
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
                d="M17.6177 19.0319C16.078 20.2635 14.125 21 12 21C7.02944 21 3 16.9706 3 12C3 7.36745 6.50005 3.55237 11 3.05493V12.4142L17.6177 19.0319ZM19.0319 17.6177L13 11.5858V3.05493C17.5 3.55237 21 7.36745 21 12C21 14.125 20.2635 16.078 19.0319 17.6177ZM23 12C23 18.0751 18.0751 23 12 23C5.92487 23 1 18.0751 1 12C1 5.92487 5.92487 1 12 1C18.0751 1 23 5.92487 23 12Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "pie_chart_stroked";
        base.OnInitialized();
    }
}
