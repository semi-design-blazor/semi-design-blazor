using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconDownCircleStroked: SIcon
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
                d="M3 12C3 7.02944 7.02944 3 12 3C16.9706 3 21 7.02944 21 12C21 16.9706 16.9706 21 12 21C7.02944 21 3 16.9706 3 12ZM12 1C5.92487 1 1 5.92487 1 12C1 18.0751 5.92487 23 12 23C18.0751 23 23 18.0751 23 12C23 5.92487 18.0751 1 12 1ZM8.81802 10.2929C8.4275 9.90237 7.79433 9.90237 7.40381 10.2929C7.01328 10.6834 7.01328 11.3166 7.40381 11.7071L11.2929 15.5962C11.6834 15.9867 12.3166 15.9867 12.7071 15.5962L16.5962 11.7071C16.9867 11.3166 16.9867 10.6834 16.5962 10.2929C16.2057 9.90237 15.5725 9.90237 15.182 10.2929L12 13.4749L8.81802 10.2929Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="down_circle_stroked";
        base.OnInitialized();
    }
}
