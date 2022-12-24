using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconLikeHeart: SIcon
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
                d="M12 5.99999C10.5 2.12432 5.75193 2.0557 3.40383 4.4038C0.865423 6.94221 0.999999 10.5 3.50001 14C5.52139 16.8299 9.83088 20.3136 11.4069 21.5438C11.7573 21.8172 12.2427 21.8172 12.5931 21.5438C14.1691 20.3136 18.4786 16.8299 20.5 14C23 10.5 23.1346 6.94221 20.5962 4.4038C18.2481 2.0557 14.5 2.12432 12 5.99999Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="like_heart";
        base.OnInitialized();
    }
}
