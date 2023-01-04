using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconRingChartStroked: SIcon
{
    protected override void OnInitialized()
    {
		Svg = builder =>
		{
builder.OpenElement(0, "svg");
builder.AddAttribute(1, "viewBox","0 0 24 24");
builder.AddAttribute(2, "fill","none");
builder.AddAttribute(3, "xmlns","http://www.w3.org/2000/svg");
builder.AddAttribute(4, "width","1em");
builder.AddAttribute(5, "height","1em");
builder.AddAttribute(6, "focusable","false");
builder.AddAttribute(7, "aria-hidden","true");
builder.AddMarkupContent(8, """
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M20.9451 13C20.4476 17.5 16.6326 21 12 21C7.02944 21 3 16.9706 3 12C3 7.36745 6.50005 3.55237 11 3.05493V7.10002C8.71776 7.56329 7 9.58104 7 12C7 14.7614 9.23858 17 12 17C14.419 17 16.4367 15.2822 16.9 13H20.9451ZM20.9451 11H16.9C16.5023 9.04087 14.9591 7.4977 13 7.10002V3.05493C17.1716 3.51608 20.4839 6.82838 20.9451 11ZM23 12C23 18.0751 18.0751 23 12 23C5.92487 23 1 18.0751 1 12C1 5.92487 5.92487 1 12 1C18.0751 1 23 5.92487 23 12ZM15 12C15 13.6569 13.6569 15 12 15C10.3431 15 9 13.6569 9 12C9 10.3431 10.3431 9 12 9C13.6569 9 15 10.3431 15 12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="ring_chart_stroked";
        base.OnInitialized();
    }
}
