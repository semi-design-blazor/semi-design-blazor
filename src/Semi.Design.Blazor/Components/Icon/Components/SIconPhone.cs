using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconPhone: SIcon
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
                d="M8 0.5C6.34315 0.5 5 1.84315 5 3.5V20.5C5 22.1569 6.34315 23.5 8 23.5H16C17.6569 23.5 19 22.1569 19 20.5V3.5C19 1.84315 17.6569 0.5 16 0.5H8ZM12 18C10.8954 18 10 18.8954 10 20C10 21.1046 10.8954 22 12 22C13.1046 22 14 21.1046 14 20C14 18.8954 13.1046 18 12 18Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="phone";
        base.OnInitialized();
    }
}
