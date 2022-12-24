using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconText: SIcon
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
                d="M3 4.5C3 3.67157 3.67157 3 4.5 3H19.5C20.3284 3 21 3.67157 21 4.5V7.5C21 8.32843 20.3284 9 19.5 9C18.6716 9 18 8.32843 18 7.5V6H13.5V19H15.5C16.3284 19 17 19.6716 17 20.5C17 21.3284 16.3284 22 15.5 22H8.5C7.67157 22 7 21.3284 7 20.5C7 19.6716 7.67157 19 8.5 19H10.5V6H6V7.5C6 8.32843 5.32843 9 4.5 9C3.67157 9 3 8.32843 3 7.5V4.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="text";
        base.OnInitialized();
    }
}