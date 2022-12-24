using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconCloud: SIcon
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
                d="M11.5 3C14.5944 3 17.1837 5.16226 17.8395 8.05827C20.7558 8.46659 23 10.9712 23 14C23 17.3137 20.3137 20 17 20H5.5C5.49998 20 5.49997 20 5.49995 20C3.01469 20 1 17.9853 1 15.5C1 13.1234 2.84229 11.1772 5.17664 11.0114C5.06115 10.5264 5 10.0204 5 9.5C5 5.91015 7.91015 3 11.5 3Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="cloud";
        base.OnInitialized();
    }
}
