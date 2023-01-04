using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCaretdown: SIcon
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
                d="M17.549 15.659L12.753 21.139C12.6591 21.2464 12.5434 21.3325 12.4135 21.3915C12.2836 21.4505 12.1427 21.481 12 21.481C11.8574 21.481 11.7164 21.4505 11.5865 21.3915C11.4566 21.3325 11.3409 21.2464 11.247 21.139L6.45101 15.659C5.88501 15.011 6.34501 14 7.20401 14H16.796C17.656 14 18.115 15.012 17.549 15.659Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="caretdown";
        base.OnInitialized();
    }
}
