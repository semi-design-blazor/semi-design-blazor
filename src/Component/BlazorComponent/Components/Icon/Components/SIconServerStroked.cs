using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconServerStroked: SIcon
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
                d="M6 1C4.89543 1 4 1.89543 4 3V21C4 22.1046 4.89543 23 6 23H18C19.1046 23 20 22.1046 20 21V3C20 1.89543 19.1046 1 18 1H6ZM6 3L18 3V13H6V3ZM6 15V21H18V15H6ZM9.5 5C8.94772 5 8.5 5.44772 8.5 6C8.5 6.55228 8.94772 7 9.5 7H14.5C15.0523 7 15.5 6.55228 15.5 6C15.5 5.44772 15.0523 5 14.5 5H9.5ZM9.5 9C8.94772 9 8.5 9.44772 8.5 10C8.5 10.5523 8.94772 11 9.5 11H14.5C15.0523 11 15.5 10.5523 15.5 10C15.5 9.44772 15.0523 9 14.5 9H9.5ZM12 19.5C12.8284 19.5 13.5 18.8284 13.5 18C13.5 17.1716 12.8284 16.5 12 16.5C11.1716 16.5 10.5 17.1716 10.5 18C10.5 18.8284 11.1716 19.5 12 19.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="server_stroked";
        base.OnInitialized();
    }
}
