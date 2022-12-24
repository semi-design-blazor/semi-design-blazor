using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconCrossStroked: SIcon
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
                d="M3.61612 19.1161C3.12796 19.6043 3.12796 20.3957 3.61612 20.8839C4.10427 21.372 4.89573 21.372 5.38388 20.8839L12.5 13.7678L19.6161 20.8839C20.1043 21.372 20.8957 21.372 21.3839 20.8839C21.872 20.3957 21.872 19.6043 21.3839 19.1161L14.2678 12L21.3839 4.88389C21.872 4.39573 21.872 3.60427 21.3839 3.11612C20.8957 2.62796 20.1043 2.62796 19.6161 3.11612L12.5 10.2322L5.38388 3.11612C4.89573 2.62796 4.10427 2.62796 3.61612 3.11612C3.12796 3.60427 3.12796 4.39573 3.61612 4.88388L10.7322 12L3.61612 19.1161Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="cross_stroked";
        base.OnInitialized();
    }
}
