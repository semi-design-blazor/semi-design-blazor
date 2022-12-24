using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTopCenterStroked: SIcon
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
                d="M3 2C2.44772 2 2 2.44772 2 3C2 3.55228 2.44772 4 3 4L21 4C21.5523 4 22 3.55229 22 3C22 2.44772 21.5523 2 21 2H3ZM7 10C6.44772 10 6 10.4477 6 11V21C6 21.5523 6.44772 22 7 22H17C17.5523 22 18 21.5523 18 21V11C18 10.4477 17.5523 10 17 10H7ZM8 20V12H16V20H8Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="top_center_stroked";
        base.OnInitialized();
    }
}
