using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconArchive: SIcon
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
                d="M3 3C2.44772 3 2 3.44772 2 4V7C2 7.55228 2.44772 8 3 8H21C21.5523 8 22 7.55228 22 7V4C22 3.44772 21.5523 3 21 3H3Z"
                fill="currentColor"
            />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M3 9.5C3 9.22386 3.22386 9 3.5 9H20.5C20.7761 9 21 9.22386 21 9.5V20C21 21.1046 20.1046 22 19 22H5C3.89543 22 3 21.1046 3 20V9.5ZM8 12C8 11.4477 8.44772 11 9 11H15C15.5523 11 16 11.4477 16 12C16 12.5523 15.5523 13 15 13H9C8.44772 13 8 12.5523 8 12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="archive";
        base.OnInitialized();
    }
}
