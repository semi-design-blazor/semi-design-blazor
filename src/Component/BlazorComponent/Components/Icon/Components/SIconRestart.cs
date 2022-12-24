using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconRestart: SIcon
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
                d="M4.5 2C3.67157 2 3 2.67157 3 3.5V20.5C3 21.3284 3.67157 22 4.5 22C5.32843 22 6 21.3284 6 20.5V3.5C6 2.67157 5.32843 2 4.5 2Z"
                fill="currentColor"
            />
            <path
                d="M8.00083 11.2137L19.3822 2.27115C20.0384 1.75562 21.0001 2.22303 21.0001 3.05746V20.9425C21.0001 21.777 20.0384 22.2444 19.3822 21.7289L8.00083 12.7863C7.49126 12.3859 7.49126 11.6141 8.00083 11.2137Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="restart";
        base.OnInitialized();
    }
}
