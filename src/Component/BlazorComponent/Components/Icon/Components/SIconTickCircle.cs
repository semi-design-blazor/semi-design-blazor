using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconTickCircle: SIcon
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
                d="M12 23C18.0751 23 23 18.0751 23 12C23 5.92487 18.0751 1 12 1C5.92487 1 1 5.92487 1 12C1 18.0751 5.92487 23 12 23ZM17.8831 9.82235L11.6854 17.4112C11.4029 17.7806 10.965 17.9981 10.5 18C10.035 18.0019 9.59533 17.788 9.30982 17.421L5.81604 13.4209C5.30744 12.767 5.42524 11.8246 6.07916 11.316C6.73308 10.8074 7.67549 10.9252 8.1841 11.5791L10.4838 14.0439L15.5 8C16.0032 7.34193 16.9446 7.21641 17.6027 7.71964C18.2608 8.22287 18.3863 9.16428 17.8831 9.82235Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="tick_circle";
        base.OnInitialized();
    }
}
