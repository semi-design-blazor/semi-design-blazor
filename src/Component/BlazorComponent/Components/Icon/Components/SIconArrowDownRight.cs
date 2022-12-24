using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconArrowDownRight: SIcon
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
                d="M19.5 5C20.3284 5 21 5.67157 21 6.5V19.5C21 20.3284 20.3284 21 19.5 21H6.5C5.67157 21 5 20.3284 5 19.5C5 18.6716 5.67157 18 6.5 18H15.8787L2.43936 4.56066C1.85357 3.97487 1.85357 3.02513 2.43936 2.43934C3.02514 1.85355 3.97489 1.85355 4.56068 2.43934L18 15.8787V6.5C18 5.67157 18.6716 5 19.5 5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="arrow_down_right";
        base.OnInitialized();
    }
}
