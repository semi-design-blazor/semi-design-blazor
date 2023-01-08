using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconAppCenter: SIcon
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
                d="M4 2C2.89543 2 2 2.89543 2 4V9C2 10.1046 2.89543 11 4 11H9C10.1046 11 11 10.1046 11 9V4C11 2.89543 10.1046 2 9 2H4ZM4 13C2.89543 13 2 13.8954 2 15V20C2 21.1046 2.89543 22 4 22H9C10.1046 22 11 21.1046 11 20V15C11 13.8954 10.1046 13 9 13H4ZM13 15C13 13.8954 13.8954 13 15 13H20C21.1046 13 22 13.8954 22 15V20C22 21.1046 21.1046 22 20 22H15C13.8954 22 13 21.1046 13 20V15ZM15 2C13.8954 2 13 2.89543 13 4V9C13 10.1046 13.8954 11 15 11H20C21.1046 11 22 10.1046 22 9V4C22 2.89543 21.1046 2 20 2H15ZM15 4H20V9H15V4Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="app_center";
        base.OnInitialized();
    }
}
