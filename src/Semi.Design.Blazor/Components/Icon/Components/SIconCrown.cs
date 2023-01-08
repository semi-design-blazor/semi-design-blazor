using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCrown: SIcon
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
                d="M0.830911 7.65904C0.591258 6.89214 1.50509 6.29012 2.11513 6.81301L3.96861 8.40171C5.48542 9.70184 7.82541 9.18404 8.65209 7.36535L11.0896 2.00282C11.4449 1.22123 12.5551 1.22123 12.9103 2.00282L15.3478 7.36535C16.1745 9.18404 18.5145 9.70184 20.0313 8.40171L21.8848 6.81301C22.4948 6.29012 23.4087 6.89215 23.169 7.65904L19.4385 20.5966C19.1776 21.4315 18.4044 22 17.5296 22H6.47035C5.59558 22 4.82231 21.4315 4.56139 20.5966L0.830911 7.65904Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="crown";
        base.OnInitialized();
    }
}
