using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconPrint: SIcon
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
                d="M7 2C5.89543 2 5 2.89543 5 4V7C5 7.55228 5.44772 8 6 8H18C18.5523 8 19 7.55228 19 7V4C19 2.89543 18.1046 2 17 2H7Z"
                fill="currentColor"
            />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M2 12C2 10.3431 3.34315 9 5 9H19C20.6569 9 22 10.3431 22 12V17C22 18.1046 21.1046 19 20 19H18V21C18 22.1046 17.1046 23 16 23H8C6.89543 23 6 22.1046 6 21V19H4C2.89543 19 2 18.1046 2 17V12ZM18 13C18.5523 13 19 12.5523 19 12C19 11.4477 18.5523 11 18 11C17.4477 11 17 11.4477 17 12C17 12.5523 17.4477 13 18 13ZM8 15H16V21H8V15Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="print";
        base.OnInitialized();
    }
}
