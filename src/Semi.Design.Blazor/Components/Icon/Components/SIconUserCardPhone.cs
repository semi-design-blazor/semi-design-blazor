using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconUserCardPhone: SIcon
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
                d="M9.78408 12.9728C9.19532 12.384 8.62842 11.7816 8.08337 11.1667C7.61979 10.6437 7.76563 9.8329 8.37089 9.48347L10.0564 8.51036C10.6361 8.17566 10.8347 7.43437 10.5 6.85465L7.46984 1.60624C7.13514 1.02652 6.39385 0.827886 5.81412 1.16259L1.6154 3.58673C1.28414 3.77798 1.07731 4.10198 1.02332 4.45274C1.02195 4.45716 1.02061 4.4626 1.0193 4.46911C0.956927 4.78067 1.05702 5.35719 1.15888 5.69262C2.33256 9.29467 4.35056 12.6816 7.2129 15.5439C10.5759 18.9069 14.663 21.1044 18.9723 22.1363L18.9747 22.134C19.4655 22.2252 19.982 22.005 20.2459 21.548L22.67 17.3493C23.0047 16.7696 22.8061 16.0283 22.2264 15.6936L16.978 12.6634C16.3982 12.3287 15.657 12.5273 15.3223 13.1071L14.1489 15.1394C13.8059 15.7336 13.0156 15.8874 12.4892 15.4474C11.5598 14.6706 10.657 13.8457 9.78408 12.9728Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="user_card_phone";
        base.OnInitialized();
    }
}