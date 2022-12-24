using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconBookmark: SIcon
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
                d="M4 21.5858V3C4 1.89543 4.89543 1 6 1H18C19.1046 1 20 1.89543 20 3V21.5858C20 22.4767 18.9229 22.9229 18.2929 22.2929L12 16L5.70711 22.2929C5.07714 22.9229 4 22.4767 4 21.5858Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="bookmark";
        base.OnInitialized();
    }
}
