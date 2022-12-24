using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconBell: SIcon
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
                d="M17.9999 9C17.9999 6.77641 16.7904 4.83534 14.9933 3.79886C14.8898 2.23579 13.5892 1 11.9999 1C10.4107 1 9.11006 2.23579 9.00658 3.79886C7.20952 4.83534 5.99995 6.77641 5.99995 9C5.99995 9 5.99995 11 5.49995 13C5.21672 14.1329 3.81039 15.9076 2.64425 17.2335C2.05586 17.9024 2.52326 19 3.41416 19H20.5857C21.4766 19 21.944 17.9024 21.3556 17.2335C20.1895 15.9076 18.7832 14.1329 18.4999 13C17.9999 11 17.9999 9 17.9999 9Z"
                fill="currentColor"
            />
            <path d="M15 20C15 21.6569 13.6569 23 12 23C10.3431 23 9 21.6569 9 20H15Z" fill="currentColor" />
        """);
builder.CloseElement();
};
Label ="bell";
        base.OnInitialized();
    }
}
