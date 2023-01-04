using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconPhoneStroke: SIcon
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
                d="M8.5 0.5C6.01472 0.5 4 2.51472 4 5V19C4 21.4853 6.01472 23.5 8.5 23.5H15.5C17.9853 23.5 20 21.4853 20 19V5C20 2.51472 17.9853 0.5 15.5 0.5H8.5ZM7 5C7 4.17157 7.67157 3.5 8.5 3.5H15.5C16.3284 3.5 17 4.17157 17 5V19C17 19.8284 16.3284 20.5 15.5 20.5H8.5C7.67157 20.5 7 19.8284 7 19V5ZM12 16C11.1716 16 10.5 16.6716 10.5 17.5C10.5 18.3284 11.1716 19 12 19C12.8284 19 13.5 18.3284 13.5 17.5C13.5 16.6716 12.8284 16 12 16Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="phone_stroke";
        base.OnInitialized();
    }
}
