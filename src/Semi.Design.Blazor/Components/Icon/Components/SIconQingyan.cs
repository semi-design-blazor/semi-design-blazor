using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconQingyan: SIcon
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
                d="M21.4288 4.14284C22.2967 4.14284 23.0003 3.43929 23.0003 2.57142C23.0003 1.70355 22.2967 1 21.4288 1C20.561 1 19.8574 1.70355 19.8574 2.57142C19.8574 3.43929 20.561 4.14284 21.4288 4.14284ZM11.2142 22.9997C16.8554 22.9997 21.4284 18.4267 21.4284 12.7855C21.4284 7.14435 16.8554 2.57129 11.2142 2.57129C5.57306 2.57129 1 7.14435 1 12.7855C1 18.4267 5.57306 22.9997 11.2142 22.9997Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="qingyan";
        base.OnInitialized();
    }
}
