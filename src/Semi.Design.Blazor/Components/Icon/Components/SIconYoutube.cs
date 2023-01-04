using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconYoutube: SIcon
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
                d="M22.5525 6.51556C22.2996 5.53583 21.5577 4.76278 20.6156 4.49901C18.8942 4.008 12.0076 4.00001 12.0076 4.00001C12.0076 4.00001 5.12209 3.99202 3.3996 4.46133C2.47626 4.72282 1.7134 5.513 1.45838 6.49158C1.0044 8.27976 1 11.9886 1 11.9886C1 11.9886 0.995605 15.7157 1.44629 17.4856C1.69911 18.4642 2.44108 19.2372 3.38422 19.501C5.12319 19.992 11.9911 20 11.9911 20C11.9911 20 18.8778 20.008 20.5991 19.5398C21.5401 19.2772 22.2853 18.5053 22.5415 17.5267C22.9965 15.7396 22.9998 12.032 22.9998 12.032C22.9998 12.032 23.0218 8.30374 22.5525 6.51556ZM9.80477 15.4245L9.81027 8.57323L15.5339 12.0046L9.80477 15.4245Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="youtube";
        base.OnInitialized();
    }
}
