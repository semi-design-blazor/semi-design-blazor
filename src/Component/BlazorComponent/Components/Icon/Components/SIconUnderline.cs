using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconUnderline: SIcon
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
                d="M7 2C6.17157 2 5.5 2.67157 5.5 3.5V11C5.5 14.5899 8.41015 17.5 12 17.5C15.5899 17.5 18.5 14.5899 18.5 11V3.5C18.5 2.67157 17.8284 2 17 2C16.1716 2 15.5 2.67157 15.5 3.5V11C15.5 12.933 13.933 14.5 12 14.5C10.067 14.5 8.5 12.933 8.5 11V3.5C8.5 2.67157 7.82843 2 7 2Z"
                fill="currentColor"
            />
            <path
                d="M5.5 19C4.67157 19 4 19.6716 4 20.5C4 21.3284 4.67157 22 5.5 22H18.5C19.3284 22 20 21.3284 20 20.5C20 19.6716 19.3284 19 18.5 19H5.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="underline";
        base.OnInitialized();
    }
}
