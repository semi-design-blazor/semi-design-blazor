using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconCheckboxTick: SIcon
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
                d="M17.4111 7.30848C18.0692 7.81171 18.1947 8.75312 17.6915 9.41119L11.1915 17.9112C10.909 18.2806 10.4711 18.4981 10.0061 18.5C9.54105 18.5019 9.10143 18.288 8.81592 17.9209L5.31592 13.4209C4.80731 12.767 4.92512 11.8246 5.57904 11.316C6.23296 10.8074 7.17537 10.9252 7.68398 11.5791L9.98988 14.5438L15.3084 7.58884C15.8116 6.93077 16.7531 6.80525 17.4111 7.30848Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="checkbox_tick";
        base.OnInitialized();
    }
}
