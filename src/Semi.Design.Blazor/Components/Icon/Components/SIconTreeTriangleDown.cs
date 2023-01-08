using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconTreeTriangleDown: SIcon
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
                d="M20.5598 9.65618L12.7546 18.6322C12.3559 19.0906 11.644 19.0906 11.2453 18.6322L3.4401 9.65618C2.8773 9.00895 3.33701 8 4.19471 8L19.8052 8C20.6629 8 21.1226 9.00895 20.5598 9.65618Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="tree_triangle_down";
        base.OnInitialized();
    }
}
