using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconChevronRight: SIcon
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
                d="M7.43934 19.7957C6.85355 19.2099 6.85355 18.2601 7.43934 17.6744L13.0962 12.0175L7.43934 6.36065C6.85355 5.77486 6.85355 4.82511 7.43934 4.23933C8.02513 3.65354 8.97487 3.65354 9.56066 4.23933L16.2782 10.9568C16.864 11.5426 16.864 12.4924 16.2782 13.0782L9.56066 19.7957C8.97487 20.3815 8.02513 20.3815 7.43934 19.7957Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="chevron_right";
        base.OnInitialized();
    }
}
