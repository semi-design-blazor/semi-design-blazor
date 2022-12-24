using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconRowsStroked: SIcon
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
                d="M19 4C20.1046 4 21 4.89543 21 6L21 9C21 10.1046 20.1046 11 19 11L5 11C3.89543 11 3 10.1046 3 9L3 6C3 4.89543 3.89543 4 5 4L19 4ZM19 9L19 6L5 6L5 9L19 9Z"
                fill="currentColor"
            />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M19 13C20.1046 13 21 13.8954 21 15L21 18C21 19.1046 20.1046 20 19 20L5 20C3.89543 20 3 19.1046 3 18L3 15C3 13.8954 3.89543 13 5 13L19 13ZM19 18L19 15L5 15L5 18L19 18Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="rows_stroked";
        base.OnInitialized();
    }
}
