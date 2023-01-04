using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconLive: SIcon
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
                d="M8.06066 1.93934C7.47487 1.35355 6.52513 1.35355 5.93934 1.93934C5.35355 2.52513 5.35355 3.47487 5.93934 4.06066L7.87868 6H5C3.34315 6 2 7.34315 2 9V19C2 20.6569 3.34315 22 5 22H19C20.6569 22 22 20.6569 22 19V9C22 7.34315 20.6569 6 19 6H16.1213L18.0607 4.06066C18.6464 3.47487 18.6464 2.52513 18.0607 1.93934C17.4749 1.35355 16.5251 1.35355 15.9393 1.93934L12 5.87868L8.06066 1.93934ZM10 10.9343V17.0657C10 17.4651 10.4451 17.7033 10.7774 17.4818L15.376 14.416C15.6728 14.2181 15.6728 13.7819 15.376 13.584L10.7773 10.5182C10.4451 10.2967 10 10.5349 10 10.9343Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="live";
        base.OnInitialized();
    }
}
