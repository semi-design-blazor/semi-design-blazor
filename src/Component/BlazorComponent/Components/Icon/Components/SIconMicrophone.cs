using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconMicrophone: SIcon
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
                d="M7.5 5.5C7.5 3.01472 9.51472 1 12 1C14.4853 1 16.5 3.01472 16.5 5.5V11.5C16.5 13.9853 14.4853 16 12 16C9.51472 16 7.5 13.9853 7.5 11.5V5.5Z"
                fill="currentColor"
            />
            <path
                d="M5 10.5C5.55228 10.5 6 10.9477 6 11.5C6 14.8137 8.68629 17.5 12 17.5C15.3137 17.5 18 14.8137 18 11.5C18 10.9477 18.4477 10.5 19 10.5C19.5523 10.5 20 10.9477 20 11.5C20 15.9183 16.4183 19.5 12 19.5C7.58172 19.5 4 15.9183 4 11.5C4 10.9477 4.44772 10.5 5 10.5Z"
                fill="currentColor"
            />
            <path
                d="M8 21C7.44772 21 7 21.4477 7 22C7 22.5523 7.44772 23 8 23H16C16.5523 23 17 22.5523 17 22C17 21.4477 16.5523 21 16 21H8Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="microphone";
        base.OnInitialized();
    }
}
