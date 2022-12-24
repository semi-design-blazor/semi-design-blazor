using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconFolder: SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V8H22C22 6 21 4 19 4H12.5523C11.8711 4 11.2102 3.76816 10.6783 3.34261L9.54783 2.43826C9.1932 2.15456 8.75258 2 8.29844 2H5Z"
                fill="currentColor"
            />
            <path d="M22 10H2V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V10Z" fill="currentColor" />
        """);
builder.CloseElement();
};
Label ="folder";
        base.OnInitialized();
    }
}
