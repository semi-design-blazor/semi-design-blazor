using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconCheckboxIndeterminate: SIcon
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
                d="M5 12.5C5 11.6716 5.67157 11 6.5 11H17.5C18.3284 11 19 11.6716 19 12.5C19 13.3284 18.3284 14 17.5 14H6.5C5.67157 14 5 13.3284 5 12.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="checkbox_indeterminate";
        base.OnInitialized();
    }
}
