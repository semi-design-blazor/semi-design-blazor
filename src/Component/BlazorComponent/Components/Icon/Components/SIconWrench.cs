using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconWrench: SIcon
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
                d="M10.5291 14.5291C9.74471 14.8332 8.89183 15 8 15C4.13401 15 1 11.866 1 8C1 7.08227 1.17661 6.20579 1.49769 5.4027C1.62323 5.08868 2.02578 5.02578 2.26491 5.26491L5.29289 8.29289C5.68342 8.68342 6.31658 8.68342 6.70711 8.29289L8.29289 6.70711C8.68342 6.31658 8.68342 5.68342 8.29289 5.29289L5.26491 2.26491C5.02578 2.02578 5.08868 1.62323 5.4027 1.49769C6.20579 1.17661 7.08227 1 8 1C11.866 1 15 4.13401 15 8C15 8.89183 14.8332 9.74471 14.5291 10.5291L22.0858 18.0858C22.8668 18.8668 22.8668 20.1332 22.0858 20.9142L20.9142 22.0858C20.1332 22.8668 18.8668 22.8668 18.0858 22.0858L10.5291 14.5291Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="wrench";
        base.OnInitialized();
    }
}
