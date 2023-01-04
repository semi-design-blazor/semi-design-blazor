using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCreditCard: SIcon
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
                d="M4 4C2.34315 4 1 5.34315 1 7V9H23V7C23 5.34315 21.6569 4 20 4H4ZM23 11H1V18C1 19.6569 2.34315 21 4 21H20C21.6569 21 23 19.6569 23 18V11ZM4 15C4 14.4477 4.44772 14 5 14H7C7.55228 14 8 14.4477 8 15V16C8 16.5523 7.55228 17 7 17H5C4.44772 17 4 16.5523 4 16V15Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="credit_card";
        base.OnInitialized();
    }
}
