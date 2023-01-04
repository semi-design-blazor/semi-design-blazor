using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconFastFoward: SIcon
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
                d="M1 5.96376C1 5.14647 1.9272 4.67432 2.58817 5.15502L10.888 11.1913C11.4371 11.5906 11.4371 12.4094 10.888 12.8087L2.58817 18.845C1.9272 19.3257 1 18.8535 1 18.0362V5.96376Z"
                fill="currentColor"
            />
            <path
                d="M12 5.96376C12 5.14647 12.9272 4.67432 13.5882 5.15502L21.888 11.1913C22.4371 11.5906 22.4371 12.4094 21.888 12.8087L13.5882 18.845C12.9272 19.3257 12 18.8535 12 18.0362V5.96376Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="fast_foward";
        base.OnInitialized();
    }
}
