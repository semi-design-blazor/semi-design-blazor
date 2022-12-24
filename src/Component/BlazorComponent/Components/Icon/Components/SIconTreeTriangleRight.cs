using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTreeTriangleRight: SIcon
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
                d="M9.65618 3.44015L18.6322 11.2454C19.0906 11.644 19.0906 12.356 18.6322 12.7546L9.65618 20.5598C9.00895 21.1226 8 20.6629 8 19.8052V4.19475C8 3.33705 9.00895 2.87734 9.65618 3.44015Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="tree_triangle_right";
        base.OnInitialized();
    }
}
