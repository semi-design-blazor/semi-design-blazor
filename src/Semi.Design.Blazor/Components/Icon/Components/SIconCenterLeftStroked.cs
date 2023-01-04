using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCenterLeftStroked: SIcon
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
                d="M4 3C4 2.44772 3.55229 2 3 2C2.44772 2 2 2.44772 2 3V21C2 21.5523 2.44772 22 3 22C3.55228 22 4 21.5523 4 21L4 3ZM11 6C10.4477 6 10 6.44772 10 7V17C10 17.5523 10.4477 18 11 18H21C21.5523 18 22 17.5523 22 17V7C22 6.44772 21.5523 6 21 6H11ZM12 16V8H20V16H12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="center_left_stroked";
        base.OnInitialized();
    }
}
