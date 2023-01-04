using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconArrowLeft: SIcon
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
                d="M23 12C23 12.8284 22.3284 13.5 21.5 13.5L6.12132 13.5L12.5607 19.9393C13.1464 20.5251 13.1464 21.4749 12.5607 22.0607C11.9749 22.6464 11.0251 22.6464 10.4393 22.0607L1.43934 13.0607C0.853554 12.4749 0.853554 11.5251 1.43934 10.9393L10.4393 1.93934C11.0251 1.35355 11.9749 1.35355 12.5607 1.93934C13.1464 2.52513 13.1464 3.47487 12.5607 4.06066L6.12132 10.5L21.5 10.5C22.3284 10.5 23 11.1716 23 12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="arrow_left";
        base.OnInitialized();
    }
}
