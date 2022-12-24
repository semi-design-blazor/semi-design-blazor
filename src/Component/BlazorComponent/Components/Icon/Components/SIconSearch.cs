using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconSearch: SIcon
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
                d="M10.5 2C5.80558 2 2 5.80558 2 10.5C2 15.1944 5.80558 19 10.5 19C12.3054 19 13.9794 18.4371 15.356 17.4773L19.4393 21.5606C20.0251 22.1464 20.9749 22.1464 21.5606 21.5606C22.1464 20.9749 22.1464 20.0251 21.5606 19.4393L17.4773 15.356C18.4371 13.9794 19 12.3054 19 10.5C19 5.80558 15.1944 2 10.5 2ZM5 10.5C5 7.46243 7.46243 5 10.5 5C13.5376 5 16 7.46243 16 10.5C16 13.5376 13.5376 16 10.5 16C7.46243 16 5 13.5376 5 10.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="search";
        base.OnInitialized();
    }
}