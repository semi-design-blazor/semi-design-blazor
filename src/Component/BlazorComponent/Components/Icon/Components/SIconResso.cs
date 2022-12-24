using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconResso: SIcon
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
                d="M6.55045 23C5.40657 22.999 4.30982 22.5442 3.50078 21.7356C2.69175 20.9269 2.23652 19.8304 2.23494 18.6865V15.1803C2.23234 14.414 2.43474 13.6609 2.82117 12.9991C3.2076 12.3373 3.76399 11.791 4.43267 11.4166C5.10134 11.0422 5.85798 10.8535 6.62414 10.87C7.3903 10.8866 8.1381 11.1077 8.79004 11.5105L14.3791 14.9304L17.4468 13.0518C17.6212 12.9485 17.7677 12.8041 17.8735 12.6313C17.9793 12.4584 18.0412 12.2623 18.0539 12.06C18.0649 11.8419 18.0171 11.6249 17.9153 11.4317C17.8136 11.2385 17.6617 11.0762 17.4756 10.962L7.49965 4.8562C7.3159 4.74286 7.1052 4.6807 6.88936 4.67616C6.67351 4.67162 6.46038 4.72485 6.27203 4.83036C6.08368 4.93587 5.92695 5.0898 5.81808 5.27623C5.70922 5.46266 5.65216 5.67481 5.65283 5.89069V8.52701C4.37479 8.68505 3.17807 9.2385 2.22998 10.11L2.23494 5.31047C2.23266 4.54426 2.43526 3.79137 2.82176 3.12978C3.20826 2.4682 3.76461 1.92197 4.43318 1.54767C5.10175 1.17338 5.85823 0.984632 6.62426 1.00098C7.3903 1.01732 8.13804 1.23817 8.79004 1.64064L19.7122 8.32567C20.3409 8.71058 20.8602 9.25041 21.2205 9.89349C21.5808 10.5366 21.77 11.2613 21.77 11.9985C21.77 12.7356 21.5808 13.4604 21.2205 14.1035C20.8602 14.7465 20.3409 15.2864 19.7122 15.6713L17.6532 16.9329L20.1209 18.4425C20.4063 18.6153 20.6346 18.8682 20.7772 19.1698C20.9199 19.4714 20.9707 19.8083 20.9233 20.1385C20.8898 20.3947 20.7971 20.6396 20.6525 20.8537C20.495 21.0871 20.2827 21.2784 20.0343 21.411C19.7859 21.5436 19.5088 21.6134 19.2272 21.6144C18.912 21.614 18.6031 21.5265 18.3345 21.3615L14.3761 18.9394L8.79004 22.3593C8.11692 22.7754 7.3418 22.9971 6.55045 23ZM7.00273 14.615C6.68057 14.615 6.37158 14.7428 6.14359 14.9704C5.9156 15.198 5.78726 15.5068 5.78673 15.829V18.1737C5.7862 18.3895 5.84332 18.6016 5.95219 18.788C6.06106 18.9744 6.21773 19.1283 6.406 19.2339C6.59428 19.3394 6.80733 19.3928 7.02313 19.3885C7.23894 19.3841 7.44967 19.3222 7.63355 19.2092L11.2379 17.0023L7.63454 14.7955C7.44466 14.6781 7.22597 14.6156 7.00273 14.615Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="resso";
        base.OnInitialized();
    }
}
