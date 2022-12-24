using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconButtonStroked: SIcon
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
                d="M2 6C1.44772 6 1 6.44772 1 7V17C1 17.5523 1.44772 18 2 18H22C22.5523 18 23 17.5523 23 17V7C23 6.44772 22.5523 6 22 6H2ZM3 16V8H21V16H3ZM7 11C6.44772 11 6 11.4477 6 12C6 12.5523 6.44771 13 7 13H17C17.5523 13 18 12.5523 18 12C18 11.4477 17.5523 11 17 11H7Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="button_stroked";
        base.OnInitialized();
    }
}
