using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconTopRightStroked: SIcon
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
                d="M3 2C2.44772 2 2 2.44772 2 3C2 3.55228 2.44772 4 3 4H20V21C20 21.5523 20.4477 22 21 22C21.5523 22 22 21.5523 22 21V3C22 2.44772 21.5523 2 21 2H3ZM3 10C2.44772 10 2 10.4477 2 11V21C2 21.5523 2.44772 22 3 22H13C13.5523 22 14 21.5523 14 21V11C14 10.4477 13.5523 10 13 10H3ZM4 20V12H12V20H4Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="top_right_stroked";
        base.OnInitialized();
    }
}
