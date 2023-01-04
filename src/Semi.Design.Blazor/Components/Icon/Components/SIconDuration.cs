using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconDuration: SIcon
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
                d="M12 23C18.075 23 23 18.075 23 12C23 5.925 18.075 1 12 1C5.925 1 1 5.925 1 12C1 18.075 5.925 23 12 23ZM19.857 12C19.8568 13.5605 19.392 15.0855 18.5217 16.3808C17.6515 17.676 16.4153 18.6828 14.9706 19.2728C13.526 19.8628 11.9384 20.0093 10.4103 19.6936C8.88208 19.3778 7.48253 18.6142 6.39 17.5L12 12V4.143C14.0838 4.143 16.0823 4.97079 17.5557 6.44426C19.0292 7.91774 19.857 9.91619 19.857 12Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="duration";
        base.OnInitialized();
    }
}
