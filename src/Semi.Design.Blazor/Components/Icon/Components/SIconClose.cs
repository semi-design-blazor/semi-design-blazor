using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconClose: SIcon
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
                d="M17.6568 19.7782C18.2426 20.3639 19.1924 20.3639 19.7782 19.7782C20.3639 19.1924 20.3639 18.2426 19.7782 17.6568L14.1213 12L19.7782 6.34313C20.3639 5.75734 20.3639 4.8076 19.7782 4.22181C19.1924 3.63602 18.2426 3.63602 17.6568 4.22181L12 9.87866L6.34313 4.22181C5.75734 3.63602 4.8076 3.63602 4.22181 4.22181C3.63602 4.8076 3.63602 5.75734 4.22181 6.34313L9.87866 12L4.22181 17.6568C3.63602 18.2426 3.63602 19.1924 4.22181 19.7782C4.8076 20.3639 5.75734 20.3639 6.34313 19.7782L12 14.1213L17.6568 19.7782Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="close";
        base.OnInitialized();
    }
}
