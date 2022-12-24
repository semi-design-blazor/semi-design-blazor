using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconFolderStroked: SIcon
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
                d="M4 4C2.89543 4 2 4.89543 2 6V18C2 19.1046 2.89543 20 4 20H20C21.1046 20 22 19.1046 22 18V8C22 6.89543 21.1046 6 20 6L11.4142 6L10 4.58579C9.62493 4.21071 9.11622 4 8.58579 4H4ZM4 6H8.58579L9.58579 7L8.58579 8H4V6ZM4 10V18H20V8H11.4142L10 9.41421C9.62493 9.78929 9.11622 10 8.58579 10H4Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="folder_stroked";
        base.OnInitialized();
    }
}
