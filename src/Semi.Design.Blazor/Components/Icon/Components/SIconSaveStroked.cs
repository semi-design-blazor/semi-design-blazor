using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconSaveStroked: SIcon
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
                d="M2 4C2 2.89543 2.89543 2 4 2H7H12H14.9608C15.4912 2 15.9999 2.21071 16.375 2.58579L21.4142 7.625C21.7893 8.00007 22 8.50878 22 9.03921V20C22 21.1046 21.1046 22 20 22H17H7H4C2.89543 22 2 21.1046 2 20V4ZM11 4H8V7H11V4ZM6 4V8C6 8.55228 6.44772 9 7 9H12C12.5523 9 13 8.55228 13 8V4H14.9608L20 9.03921V20H18V15C18 14.4477 17.5523 14 17 14H7C6.44772 14 6 14.4477 6 15V20H4V4H6ZM16 16V20H8V16H16Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="save_stroked";
        base.OnInitialized();
    }
}
