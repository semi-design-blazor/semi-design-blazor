using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconCamera: SIcon
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
                d="M7.44721 3.10557C7.786 2.428 8.47852 2 9.23607 2H14.7639C15.5215 2 16.214 2.428 16.5528 3.10557L17.5 5H20C21.6569 5 23 6.34315 23 8V18C23 19.6569 21.6569 21 20 21H4C2.34315 21 1 19.6569 1 18V8C1 6.34315 2.34315 5 4 5H6.5L7.44721 3.10557ZM9 13C9 11.3431 10.3431 10 12 10C13.6569 10 15 11.3431 15 13C15 14.6569 13.6569 16 12 16C10.3431 16 9 14.6569 9 13ZM12 8C9.23858 8 7 10.2386 7 13C7 15.7614 9.23858 18 12 18C14.7614 18 17 15.7614 17 13C17 10.2386 14.7614 8 12 8Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="camera";
        base.OnInitialized();
    }
}
