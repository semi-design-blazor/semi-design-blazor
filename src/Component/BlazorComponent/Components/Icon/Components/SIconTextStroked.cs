using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTextStroked: SIcon
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
                d="M4 2C3.44772 2 3 2.44772 3 3V6C3 6.55228 3.44772 7 4 7C4.55228 7 5 6.55228 5 6V4H11V20H9C8.44772 20 8 20.4477 8 21C8 21.5523 8.44772 22 9 22H15C15.5523 22 16 21.5523 16 21C16 20.4477 15.5523 20 15 20H13V4H19V6C19 6.55228 19.4477 7 20 7C20.5523 7 21 6.55228 21 6V3C21 2.44772 20.5523 2 20 2H4Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="text_stroked";
        base.OnInitialized();
    }
}
