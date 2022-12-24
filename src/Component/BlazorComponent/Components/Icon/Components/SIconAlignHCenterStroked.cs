using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconAlignHCenterStroked: SIcon
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
                d="M11 3C11 2.44772 11.4477 2 12 2C12.5523 2 13 2.44772 13 3V5H20C20.5523 5 21 5.44772 21 6V10C21 10.5523 20.5523 11 20 11H13V13H17C17.5523 13 18 13.4477 18 14V18C18 18.5523 17.5523 19 17 19H13V21C13 21.5523 12.5523 22 12 22C11.4477 22 11 21.5523 11 21V19H7C6.44772 19 6 18.5523 6 18V14C6 13.4477 6.44772 13 7 13H11V11H4C3.44772 11 3 10.5523 3 10V6C3 5.44772 3.44772 5 4 5H11V3ZM12 17H16V15H12H8V17H12ZM19 9H12H5V7H12H19V9Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="align_h_center_stroked";
        base.OnInitialized();
    }
}
