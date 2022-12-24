using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconBytedanceLogo: SIcon
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
                d="M18.605 3L22 3.86879V19.5071L18.605 20.5V3ZM2 3.99291L5.33333 4.79964V18.7004L2 19.6312V3.99291ZM7.49384 10.9433L10.8272 11.8741V19.1347L7.49384 20.0656V10.9433ZM16.4444 8.70922L13.1728 9.51595V16.8386L16.4444 17.8316V8.70922Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="bytedance_logo";
        base.OnInitialized();
    }
}
