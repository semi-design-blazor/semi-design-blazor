using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconComponentStroked: SIcon
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
                d="M1 9C1 8.44772 1.44772 8 2 8H22C22.5523 8 23 8.44772 23 9V15C23 15.5523 22.5523 16 22 16H2C1.44772 16 1 15.5523 1 15V9ZM3 10V14H21V10H3Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="component_stroked";
        base.OnInitialized();
    }
}
