using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconBottomCenterStroked: SIcon
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
                d="M7 2C6.44771 2 6 2.44772 6 3V13C6 13.5523 6.44771 14 7 14H17C17.5523 14 18 13.5523 18 13V3C18 2.44772 17.5523 2 17 2H7ZM8 12V4H16V12H8ZM3 20C2.44772 20 2 20.4477 2 21C2 21.5523 2.44771 22 3 22L21 22C21.5523 22 22 21.5523 22 21C22 20.4477 21.5523 20 21 20L3 20Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="bottom_center_stroked";
        base.OnInitialized();
    }
}
