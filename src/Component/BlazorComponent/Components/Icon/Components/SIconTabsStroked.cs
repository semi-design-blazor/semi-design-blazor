using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTabsStroked: SIcon
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
                d="M2 5C2 3.89543 2.89543 3 4 3H8H10H14H16H20C21.1046 3 22 3.89543 22 5V19C22 20.1046 21.1046 21 20 21H4C2.89543 21 2 20.1046 2 19V5ZM14 5H10V7H14V5ZM16 7H20V5H16V7ZM4 5H8V8C8 8.55228 8.44772 9 9 9H20V19H4V5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="tabs_stroked";
        base.OnInitialized();
    }
}
