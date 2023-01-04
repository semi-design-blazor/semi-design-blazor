using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconAlertCircle: SIcon
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
                d="M23 12C23 18.0751 18.0751 23 12 23C5.92487 23 1 18.0751 1 12C1 5.92487 5.92487 1 12 1C18.0751 1 23 5.92487 23 12ZM13.5 17.5C13.5 16.6716 12.8284 16 12 16C11.1716 16 10.5 16.6716 10.5 17.5C10.5 18.3284 11.1716 19 12 19C12.8284 19 13.5 18.3284 13.5 17.5ZM12 5C10.9138 5 10.0507 5.91244 10.1109 6.99692L10.4168 12.5023C10.4635 13.3426 11.1584 14 12 14C12.8416 14 13.5365 13.3426 13.5832 12.5023L13.8891 6.99692C13.9493 5.91244 13.0862 5 12 5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="alert_circle";
        base.OnInitialized();
    }
}
