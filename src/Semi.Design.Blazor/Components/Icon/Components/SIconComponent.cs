using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconComponent: SIcon
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
            <path d="M6 4L11 0L16 4L11 9.5L6 4Z" fill="currentColor" />
            <path d="M18 6L22 11L18 16L12.5 11L18 6Z" fill="currentColor" />
            <path d="M4 16L0 11L4 6L9.5 11L4 16Z" fill="currentColor" />
            <path d="M16 18L11 22L6 18L11 12.5L16 18Z" fill="currentColor" />
        """);
builder.CloseElement();
};
Label ="component";
        base.OnInitialized();
    }
}
