using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconChevronUpDown: SIcon
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
                d="M6.68934 6.68198C6.10355 7.26777 6.10355 8.21751 6.68934 8.8033C7.27513 9.38909 8.22487 9.38909 8.81066 8.8033L11.9926 5.62132L15.1746 8.8033C15.7604 9.38909 16.7102 9.38909 17.2959 8.8033C17.8817 8.21751 17.8817 7.26777 17.2959 6.68198L13.0533 2.43934C12.4675 1.85355 11.5178 1.85355 10.932 2.43934L6.68934 6.68198Z"
                fill="currentColor"
            />
            <path
                d="M17.296 17.318C17.8817 16.7322 17.8817 15.7825 17.296 15.1967C16.7102 14.6109 15.7604 14.6109 15.1746 15.1967L11.9927 18.3787L8.81067 15.1967C8.22488 14.6109 7.27514 14.6109 6.68935 15.1967C6.10356 15.7825 6.10356 16.7322 6.68935 17.318L10.932 21.5607C11.5178 22.1464 12.4675 22.1464 13.0533 21.5607L17.296 17.318Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="chevron_up_down";
        base.OnInitialized();
    }
}
