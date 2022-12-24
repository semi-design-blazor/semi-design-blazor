using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconSmallTriangleLeft: SIcon
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
                d="M16.3176 6.95628V17.0878C16.3176 17.4871 15.8725 17.7253 15.5402 17.5038L7.94161 12.438C7.64474 12.2401 7.64474 11.8039 7.94161 11.606L15.5402 6.54025C15.8725 6.31873 16.3176 6.55693 16.3176 6.95628Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="small_triangle_left";
        base.OnInitialized();
    }
}
