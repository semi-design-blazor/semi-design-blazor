using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconLikeThumb: SIcon
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
                d="M8.05882 9.38973L11.7724 2.42678C11.8993 2.18883 12.1914 2.09699 12.4121 2.25201C12.9945 2.66123 13.8333 3.45218 13.8333 4.37503C13.8333 4.87411 13.7011 5.7719 13.5626 6.71262C13.4101 7.74781 13.25 8.83498 13.25 9.50003H20.8333C21.2778 9.50003 22 9.95175 22 11C22 11.904 21.0084 16.0872 20.3079 19.0423C20.1961 19.5138 20.0917 19.9541 20 20.3449C20 20.5632 19.7333 21 18.6667 21H8.49796C8.22182 21 8 20.7762 8 20.5V9.62503C8 9.54296 8.0202 9.46215 8.05882 9.38973ZM3.5 9.50003C3.22386 9.50003 3 9.72389 3 10V20.5C3 20.7762 3.22386 21 3.5 21H5.5C5.77614 21 6 20.7762 6 20.5V10C6 9.72389 5.77614 9.50003 5.5 9.50003H3.5Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="like_thumb";
        base.OnInitialized();
    }
}
