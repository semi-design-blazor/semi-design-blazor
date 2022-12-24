using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconShieldStroked: SIcon
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
                d="M3 4.12781L12.0013 2.5L21 4.12781V9.51683C21 15.1811 17.3751 20.2095 12.0013 22C6.62604 20.2095 3 15.18 3 9.51434V4.12781Z"
                stroke="currentColor"
                strokeWidth={2}
                strokeLinejoin="round"
            />
            <path
                d="M11.9749 7.47485V15.4749"
                stroke="currentColor"
                strokeWidth={2}
                strokeLinecap="round"
                strokeLinejoin="round"
            />
            <path
                d="M7.97485 11.4749H15.9749"
                stroke="currentColor"
                strokeWidth={2}
                strokeLinecap="round"
                strokeLinejoin="round"
            />
        """);
builder.CloseElement();
};
Label ="shield_stroked";
        base.OnInitialized();
    }
}
