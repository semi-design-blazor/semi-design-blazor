using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconPlus: SIcon
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
                d="M20.5 13.5C21.3284 13.5 22 12.8284 22 12C22 11.1716 21.3284 10.5 20.5 10.5L13.5 10.5L13.5 3.5C13.5 2.67157 12.8284 2 12 2C11.1716 2 10.5 2.67157 10.5 3.5L10.5 10.5L3.5 10.5C2.67157 10.5 2 11.1716 2 12C2 12.8284 2.67157 13.5 3.5 13.5L10.5 13.5V20.5C10.5 21.3284 11.1716 22 12 22C12.8284 22 13.5 21.3284 13.5 20.5V13.5L20.5 13.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="plus";
        base.OnInitialized();
    }
}
