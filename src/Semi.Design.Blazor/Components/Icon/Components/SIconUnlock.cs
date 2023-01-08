using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconUnlock: SIcon
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
                d="M5.5 7.5C5.5 3.91015 8.41015 1 12 1C15.4216 1 18.2257 3.64378 18.4811 7H15.4646C15.2219 5.30385 13.7632 4 12 4C10.067 4 8.5 5.567 8.5 7.5V10H19C20.1046 10 21 10.8954 21 12V20C21 21.1046 20.1046 22 19 22H5C3.89543 22 3 21.1046 3 20V12C3 10.8954 3.89543 10 5 10H5.5V7.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="unlock";
        base.OnInitialized();
    }
}
