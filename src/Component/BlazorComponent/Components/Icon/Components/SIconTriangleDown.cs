using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTriangleDown: SIcon
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
                d="M21.8329 6.59139L12.8063 18.9004C12.4068 19.4452 11.5931 19.4452 11.1935 18.9004L2.16693 6.59139C1.68255 5.93086 2.15424 5.00003 2.97334 5.00003L21.0265 5.00003C21.8456 5.00003 22.3173 5.93087 21.8329 6.59139Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="triangle_down";
        base.OnInitialized();
    }
}
