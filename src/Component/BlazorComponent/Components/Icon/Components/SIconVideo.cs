using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconVideo: SIcon
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
                d="M5 2C3.34315 2 2 3.34315 2 5V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V5C22 3.34315 20.6569 2 19 2H5ZM9 7.86852C9 7.06982 9.89015 6.59343 10.5547 7.03647L16.7519 11.1679C17.3457 11.5638 17.3457 12.4362 16.7519 12.8321L10.5547 16.9635C9.89015 17.4066 9 16.9302 9 16.1315V7.86852Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="video";
        base.OnInitialized();
    }
}
