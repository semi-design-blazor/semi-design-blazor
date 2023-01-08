using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCarouselStroked: SIcon
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
                d="M1 6H3V18H1V20H4C4.55228 20 5 19.5523 5 19V5C5 4.44772 4.55228 4 4 4H1V6ZM7 5C7 4.44772 7.44772 4 8 4H16C16.5523 4 17 4.44772 17 5V19C17 19.5523 16.5523 20 16 20H8C7.44772 20 7 19.5523 7 19V5ZM9 6V18H15V6H9ZM19 5C19 4.44772 19.4477 4 20 4H23V6H21V18H23V20H20C19.4477 20 19 19.5523 19 19V5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="carousel_stroked";
        base.OnInitialized();
    }
}
