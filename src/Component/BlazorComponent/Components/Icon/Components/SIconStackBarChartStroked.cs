using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconStackBarChartStroked: SIcon
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
                d="M10 2C9.44772 2 9 2.44772 9 3V10V21C9 21.5523 9.44772 22 10 22H14C14.5523 22 15 21.5523 15 21V10V3C15 2.44772 14.5523 2 14 2H10ZM13 11H11V20H13V11ZM13 9V4H11V9H13ZM3 7C2.44772 7 2 7.44772 2 8V13V21C2 21.5523 2.44772 22 3 22H7C7.55228 22 8 21.5523 8 21V13V8C8 7.44772 7.55228 7 7 7H3ZM6 14H4V20H6V14ZM6 12V9H4V12H6ZM16 11C16 10.4477 16.4477 10 17 10H21C21.5523 10 22 10.4477 22 11V17V21C22 21.5523 21.5523 22 21 22H17C16.4477 22 16 21.5523 16 21V17V11ZM18 16H20V12H18V16ZM18 18V20H20V18H18Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="stack_bar_chart_stroked";
        base.OnInitialized();
    }
}
