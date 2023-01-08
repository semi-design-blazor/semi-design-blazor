using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconHome: SIcon
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
                d="M2 11.4454C2 11.1619 2.12032 10.8917 2.33104 10.7021L11.331 2.60207C11.7113 2.2598 12.2887 2.2598 12.669 2.60207L21.669 10.7021C21.8797 10.8917 22 11.1619 22 11.4454V20C22 21.1046 21.1046 22 20 22H16C15.4477 22 15 21.5523 15 21V17C15 15.3432 13.6569 14 12 14C10.3431 14 9 15.3432 9 17V21C9 21.5523 8.55228 22 8 22H4C2.89543 22 2 21.1046 2 20V11.4454Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="home";
        base.OnInitialized();
    }
}
