using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconSave: SIcon
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
                d="M2 4V20C2 21.1046 2.89543 22 4 22H20C21.1046 22 22 21.1046 22 20V8.41421C22 8.149 21.8946 7.89464 21.7071 7.70711L16.2929 2.29289C16.1054 2.10536 15.851 2 15.5858 2H4C2.89543 2 2 2.89543 2 4ZM10 4V7H12V4H14C14.5523 4 15 4.44772 15 5V8C15 8.55228 14.5523 9 14 9H7C6.44772 9 6 8.55228 6 8V5C6 4.44772 6.44772 4 7 4H10ZM7 19C6.44772 19 6 18.5523 6 18V14C6 13.4477 6.44771 13 7 13H17C17.5523 13 18 13.4477 18 14V18C18 18.5523 17.5523 19 17 19H7Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="save";
        base.OnInitialized();
    }
}
