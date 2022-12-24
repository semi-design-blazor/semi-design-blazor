using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconHistogram: SIcon
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
                d="M17 2C16.4477 2 16 2.44772 16 3V19H14V10C14 9.44772 13.5523 9 13 9H11C10.4477 9 10 9.44771 10 10V19H8V8C8 7.44772 7.55228 7 7 7H5C4.44772 7 4 7.44772 4 8V19H3C2.44772 19 2 19.4477 2 20V21C2 21.5523 2.44772 22 3 22H21C21.5523 22 22 21.5523 22 21V20C22 19.4477 21.5523 19 21 19H20V3C20 2.44772 19.5523 2 19 2H17Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="histogram";
        base.OnInitialized();
    }
}
