using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconSemiLogo: SIcon
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
                d="M10.6201 17.5C6.06377 17.5 2.37012 13.8063 2.37012 9.25C2.37012 4.69365 6.06377 1 10.6201 1V17.5ZM13.3701 6.5C17.9265 6.5 21.6201 10.1936 21.6201 14.75C21.6201 19.3063 17.9265 23 13.3701 23V6.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="semi_logo";
        base.OnInitialized();
    }
}
