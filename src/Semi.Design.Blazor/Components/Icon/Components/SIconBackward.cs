using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconBackward: SIcon
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
                d="M12 18.0362C12 18.8535 11.0728 19.3257 10.4118 18.845L2.11202 12.8087C1.56292 12.4094 1.56292 11.5906 2.11202 11.1913L10.4118 5.15502C11.0728 4.67432 12 5.14647 12 5.96376V18.0362Z"
                fill="currentColor"
            />
            <path
                d="M23 18.0362C23 18.8535 22.0728 19.3257 21.4118 18.845L13.112 12.8087C12.5629 12.4094 12.5629 11.5906 13.112 11.1913L21.4118 5.15502C22.0728 4.67432 23 5.14647 23 5.96376V18.0362Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="backward";
        base.OnInitialized();
    }
}
