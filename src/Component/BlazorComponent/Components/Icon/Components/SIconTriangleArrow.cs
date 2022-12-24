using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTriangleArrow: SIcon
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
            <g clipPath="url(#clip_triangle_arrow)">
                <path
                    d="M24 9L24 10C20 10 18.5 11 16.5 13C14.5 15 14 16 12 16C10 16 9.5 15 7.5 13C5.5 11 4 10 -4.37115e-08 10L0 9L24 9Z"
                    fill="currentColor"
                />
            </g>
            <defs>
                <clipPath id="clip_triangle_arrow">
                    <rect width={24} height={24} fill="currentColor" transform="translate(24) rotate(90)" />
                </clipPath>
            </defs>
        """);
builder.CloseElement();
};
Label ="triangle_arrow";
        base.OnInitialized();
    }
}
