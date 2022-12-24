using Microsoft.AspNetCore.Components.Rendering;
namespace BlazorComponent;
public class SIconToutiaoLogo: SIcon
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
                d="M24 4L0 5.25348V19.4631L24 18.2096V4ZM20.9478 6.58957L21.0738 6.58338V8.09705C20.6504 8.49767 20.0144 9.07589 18.9055 9.70573C19.6737 9.86474 20.5617 10.0072 21.588 10.127V11.5147C19.6035 11.2938 18.0898 10.9861 16.921 10.6474C15.7356 11.1203 14.2343 11.587 12.32 11.9979V10.6102C13.3237 10.3893 14.1951 10.16 14.9509 9.92875C14.129 9.55084 13.6004 9.18741 13.1998 8.91069C13.1399 8.86939 12.5782 8.46257 12.5782 8.46257L13.9783 6.30253L15.3743 6.88075L20.9478 6.58957ZM11.6675 13.7594L8.00409 13.9515C7.41968 14.8931 6.50899 15.7811 5.08204 17.0387L2.7568 17.1606C2.84282 17.0868 2.92584 17.0146 3.00716 16.9439L3.00735 16.9437L3.05004 16.9066L3.08667 16.8748C4.49999 15.6488 5.47391 14.804 6.13522 14.0485L2.39955 14.2447V12.9437L7.03145 12.7021C7.54771 11.5209 7.58902 9.87093 7.62619 6.96127L9.10269 6.88487C9.06552 9.65823 9.0139 11.3185 8.61122 12.6195L11.6696 12.4605L11.6675 13.7594ZM3.25654 7.51472V8.96644L6.53997 9.26381V7.81207L3.25654 7.51472ZM6.53791 11.7192V10.2674L3.25448 9.97005V11.4218L6.53791 11.7192ZM17.6974 13.4435L21.588 13.2411V11.9401L17.6974 12.1425V11.4032L16.1879 11.4817V12.221L12.32 12.4233V13.7243L16.1879 13.5219V16.4564L17.6974 16.3779V13.4435ZM9.88328 16.7868L11.6654 16.6939L10.2343 14.4843L8.45221 14.5772L9.88328 16.7868ZM21.5983 16.1755L19.8162 16.2685L18.3851 14.0588L20.1672 13.9659L21.5983 16.1755ZM12.3262 16.6587L14.1063 16.5658L15.5395 14.2055L13.7573 14.2984L12.3262 16.6587ZM19.1925 7.98142L14.7052 8.21683C15.2194 8.52452 15.9235 8.87351 16.9643 9.20598C18.0051 8.76406 18.701 8.34074 19.1925 7.98142Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="toutiao_logo";
        base.OnInitialized();
    }
}
