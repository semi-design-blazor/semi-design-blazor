using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCoinMoneyStroked: SIcon
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
                d="M3 12C3 7.02944 7.02944 3 12 3C16.9706 3 21 7.02944 21 12C21 16.9706 16.9706 21 12 21C7.02944 21 3 16.9706 3 12ZM12 1C5.92487 1 1 5.92487 1 12C1 18.0751 5.92487 23 12 23C18.0751 23 23 18.0751 23 12C23 5.92487 18.0751 1 12 1ZM8.79289 7.29289C9.18342 6.90237 9.81658 6.90237 10.2071 7.29289L12 9.08579L13.7929 7.29289C14.1834 6.90237 14.8166 6.90237 15.2071 7.29289C15.5976 7.68342 15.5976 8.31658 15.2071 8.70711L13.9142 10H15C15.5523 10 16 10.4477 16 11C16 11.5523 15.5523 12 15 12H13V13H15C15.5523 13 16 13.4477 16 14C16 14.5523 15.5523 15 15 15H13V16C13 16.5523 12.5523 17 12 17C11.4477 17 11 16.5523 11 16V15H9C8.44772 15 8 14.5523 8 14C8 13.4477 8.44772 13 9 13H11V12H9C8.44772 12 8 11.5523 8 11C8 10.4477 8.44772 10 9 10H10.0858L8.79289 8.70711C8.40237 8.31658 8.40237 7.68342 8.79289 7.29289Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="coin_money_stroked";
        base.OnInitialized();
    }
}