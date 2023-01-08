using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconFilledArrowUp: SIcon
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
                d="M1.8535 11.1464L11.6464 1.35354C11.8417 1.15828 12.1582 1.15828 12.3535 1.35354L22.1464 11.1464C22.4614 11.4614 22.2383 12 21.7928 12H15.9999V21C15.9999 21.5523 15.5522 22 14.9999 22H8.99995C8.44767 22 7.99995 21.5523 7.99995 21V12H2.20706C1.7616 12 1.53852 11.4614 1.8535 11.1464Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="filled_arrow_up";
        base.OnInitialized();
    }
}
