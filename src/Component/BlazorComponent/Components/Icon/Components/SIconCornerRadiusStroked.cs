using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconCornerRadiusStroked: SIcon
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
                d="M12 4H16H19H21C21.5523 4 22 3.55228 22 3C22 2.44772 21.5523 2 21 2H12C6.47715 2 2 6.47715 2 12V21C2 21.5523 2.44772 22 3 22C3.55228 22 4 21.5523 4 21V19V18V12C4 7.58172 7.58172 4 12 4Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="corner_radius_stroked";
        base.OnInitialized();
    }
}
