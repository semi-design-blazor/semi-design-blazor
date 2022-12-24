using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconAlignTop: SIcon
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
                d="M11.9394 22C11.111 22 10.4394 21.3284 10.4394 20.5L10.4394 11.1213L8.06076 13.5C7.47497 14.0858 6.52522 14.0858 5.93944 13.5C5.35365 12.9142 5.35365 11.9645 5.93944 11.3787L10.8788 6.43934C11.4646 5.85355 12.4143 5.85355 13.0001 6.43934L18.0608 11.5C18.6466 12.0858 18.6466 13.0355 18.0608 13.6213C17.475 14.2071 16.5252 14.2071 15.9394 13.6213L13.4394 11.1213L13.4394 20.5C13.4394 21.3284 12.7679 22 11.9394 22Z"
                fill="currentColor"
            />
            <path
                fillRule="evenodd"
                clipRule="evenodd"
                d="M19.4382 2C20.2667 2 20.9382 2.67157 20.9382 3.5C20.9382 4.32843 20.2667 5 19.4382 5L4.43823 5C3.6098 5 2.93823 4.32843 2.93823 3.5C2.93823 2.67157 3.60981 2 4.43823 2L19.4382 2Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="align_top";
        base.OnInitialized();
    }
}
