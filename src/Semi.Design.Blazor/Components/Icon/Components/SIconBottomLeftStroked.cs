using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconBottomLeftStroked: SIcon
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
                d="M4 3C4 2.44772 3.55228 2 3 2C2.44772 2 2 2.44772 2 3V21C2 21.5523 2.44772 22 3 22H21C21.5523 22 22 21.5523 22 21C22 20.4477 21.5523 20 21 20H4V3ZM11 2C10.4477 2 10 2.44772 10 3V13C10 13.5523 10.4477 14 11 14H21C21.5523 14 22 13.5523 22 13V3C22 2.44772 21.5523 2 21 2H11ZM12 12V4H20V12H12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="bottom_left_stroked";
        base.OnInitialized();
    }
}
