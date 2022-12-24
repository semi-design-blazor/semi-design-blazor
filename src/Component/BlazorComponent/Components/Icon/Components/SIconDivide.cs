using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconDivide: SIcon
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
                d="M14.5 5.5C14.5 6.88071 13.3807 8 12 8C10.6193 8 9.5 6.88071 9.5 5.5C9.5 4.11929 10.6193 3 12 3C13.3807 3 14.5 4.11929 14.5 5.5Z"
                fill="currentColor"
            />
            <path
                d="M2 12C2 11.1716 2.67157 10.5 3.5 10.5H20.5C21.3284 10.5 22 11.1716 22 12C22 12.8284 21.3284 13.5 20.5 13.5H3.5C2.67157 13.5 2 12.8284 2 12Z"
                fill="currentColor"
            />
            <path
                d="M12 21C13.3807 21 14.5 19.8807 14.5 18.5C14.5 17.1193 13.3807 16 12 16C10.6193 16 9.5 17.1193 9.5 18.5C9.5 19.8807 10.6193 21 12 21Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="divide";
        base.OnInitialized();
    }
}
