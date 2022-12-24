using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconLightningStroked: SIcon
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
                d="M10.0967 10.5789C10.1587 10.5789 10.2057 10.6347 10.1953 10.6958L9.10684 17.0647L16.1242 9.94737H13.0463C12.9715 9.94737 12.9232 9.86829 12.9573 9.80175L16.4445 3H9.7179L6.22076 10.5789H10.0967ZM8.30406 1.29051C8.38577 1.11341 8.56301 1 8.75806 1H18.8992C19.2731 1 19.5148 1.39539 19.3442 1.72811L16.1556 7.94737H19.7096C20.1534 7.94737 20.3772 8.48242 20.0657 8.79841L7.18038 21.8672C6.83686 22.2156 6.24906 21.9142 6.33148 21.4319L7.84446 12.5789H3.87663C3.51175 12.5789 3.26975 12.2008 3.42263 11.8695L8.30406 1.29051Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="lightning_stroked";
        base.OnInitialized();
    }
}
