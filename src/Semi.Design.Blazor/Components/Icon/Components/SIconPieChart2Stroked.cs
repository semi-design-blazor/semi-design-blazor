namespace Semi.Design.Blazor;
public class SIconPieChart2Stroked : SIcon
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
                d="M11 3.05493C6.50005 3.55237 3 7.36745 3 12C3 16.9706 7.02944 21 12 21C14.125 21 16.078 20.2635 17.6177 19.0319L11.1464 12.5607C11.0527 12.4669 11 12.3397 11 12.2071V3.05493ZM13 3.05493V11L20.9451 11C20.4839 6.82838 17.1716 3.51608 13 3.05493ZM14.4142 13L19.0319 17.6177C20.0676 16.3229 20.7532 14.7359 20.9451 13L14.4142 13ZM1 12C1 5.92487 5.92487 1 12 1C18.0751 1 23 5.92487 23 12C23 18.0751 18.0751 23 12 23C5.92487 23 1 18.0751 1 12Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "pie_chart2_stroked";
        base.OnInitialized();
    }
}
