using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconInbox: SIcon
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
                d="M0.21457 12.4636C0.0728256 12.8179 0 13.1961 0 13.5777V19C0 20.6569 1.34315 22 3 22H21C22.6569 22 24 20.6569 24 19V13.5777C24 13.1961 23.9272 12.8179 23.7854 12.4636L20.5029 4.25722C20.1992 3.4979 19.4637 3 18.6459 3H5.35407C4.53626 3 3.80084 3.4979 3.49711 4.25722L0.21457 12.4636ZM5.5 6H18.5L21 13H16C15.4477 13 15 13.4477 15 14C15 15.6569 13.6569 17 12 17C10.3431 17 9 15.6569 9 14C9 13.4477 8.55228 13 8 13H3L5.5 6Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="inbox";
        base.OnInitialized();
    }
}
