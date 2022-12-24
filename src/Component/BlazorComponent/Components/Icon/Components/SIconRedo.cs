using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconRedo: SIcon
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
                d="M14.4393 2.43934C13.8536 3.02513 13.8536 3.97487 14.4393 4.56066L16.8787 7H9.25C5.1647 7 2 10.5796 2 14.5C2 18.4204 5.1647 22 9.25 22H12.5C13.3284 22 14 21.3284 14 20.5C14 19.6716 13.3284 19 12.5 19H9.25C6.98402 19 5 16.9308 5 14.5C5 12.0692 6.98402 10 9.25 10H16.8787L14.4393 12.4393C13.8536 13.0251 13.8536 13.9749 14.4393 14.5607C15.0251 15.1464 15.9749 15.1464 16.5607 14.5607L21.5607 9.56066C22.1464 8.97487 22.1464 8.02513 21.5607 7.43934L16.5607 2.43934C15.9749 1.85355 15.0251 1.85355 14.4393 2.43934Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="redo";
        base.OnInitialized();
    }
}
