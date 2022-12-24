using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconChevronUp: SIcon
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
                d="M19.637 16.4369C19.0513 17.0227 18.1015 17.0227 17.5157 16.4369L11.8589 10.7801L6.20202 16.4369C5.61623 17.0227 4.66648 17.0227 4.0807 16.4369C3.49491 15.8511 3.49491 14.9014 4.0807 14.3156L10.7982 7.59809C11.384 7.01231 12.3337 7.01231 12.9195 7.59809L19.637 14.3156C20.2228 14.9014 20.2228 15.8511 19.637 16.4369Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="chevron_up";
        base.OnInitialized();
    }
}
