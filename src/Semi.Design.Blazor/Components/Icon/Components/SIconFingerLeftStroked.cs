using Microsoft.AspNetCore.Components.Rendering;
namespace Semi.Design.Blazor;
public class SIconFingerLeftStroked: SIcon
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
                d="M6.70711 3.70711C7.09763 3.31658 7.09763 2.68342 6.70711 2.29289C6.31658 1.90237 5.68342 1.90237 5.29289 2.29289L2.29289 5.29289C1.90237 5.68342 1.90237 6.31658 2.29289 6.70711L5.29289 9.70711C5.68342 10.0976 6.31658 10.0976 6.70711 9.70711C7.09763 9.31658 7.09763 8.68342 6.70711 8.29289L5.41421 7H8.84519C8.84744 9.37149 8.84859 11.2546 8.84863 12.6495C8.62182 12.3907 8.31242 12.154 7.88855 12.0352C7.36911 11.8895 6.84076 11.8231 6.35381 11.9482C5.80382 12.0895 5.41679 12.4468 5.2067 12.9045C5.02185 13.3073 4.99335 13.742 5.0011 14.0877C5.00917 14.4471 5.06099 14.8225 5.11479 15.1582C5.26435 16.0916 5.75058 18.0106 9.10435 21.6751C9.29378 21.8821 9.56145 22 9.84204 22H20.842C21.3943 22 21.842 21.5523 21.842 21V13.534C21.842 12.5683 21.5057 11.8305 21.0064 11.3192C20.5306 10.8319 19.9572 10.6006 19.5248 10.5229C19.186 10.4621 17.2831 10.1688 13.8462 9.64706V7H21C21.5523 7 22 6.55228 22 6C22 5.44772 21.5523 5 21 5H13.7958C13.5634 3.85876 12.554 3 11.3441 3L11.3426 3L11.3415 3C10.1328 3.00127 9.12541 3.85991 8.89378 5H5.41421L6.70711 3.70711ZM10.8437 5.50099C10.8434 5.2247 11.067 5.00049 11.3433 5C11.6206 5 11.8462 5.2248 11.8462 5.50208V10.5068C11.8462 11.0012 12.2075 11.4214 12.6963 11.4955C16.6946 12.1017 18.8403 12.432 19.1713 12.4914C19.2611 12.5076 19.4348 12.5725 19.5754 12.7164C19.6926 12.8364 19.842 13.0652 19.842 13.534V20H10.286C7.39867 16.7673 7.15944 15.2777 7.08959 14.8418C7.03857 14.5234 7.00546 14.2593 7.0006 14.0428C6.99921 13.9808 7.00041 13.9299 7.00288 13.8886C7.07932 13.8972 7.1878 13.9165 7.33517 13.9572C7.34782 13.9694 7.37276 13.9987 7.40947 14.0605C7.49702 14.2081 7.56532 14.3879 7.67178 14.6682L7.72198 14.8001C7.83531 15.0967 8.00848 15.5426 8.30473 15.9061C8.64752 16.3266 9.15579 16.6407 9.84204 16.6407V16.6019C10.1756 16.5421 10.5449 16.3478 10.6575 16.2196C10.7098 16.1377 10.7742 16.0028 10.7919 15.9534C10.8174 15.876 10.8275 15.8121 10.8298 15.7974L10.8298 15.7974L10.83 15.7962C10.8364 15.7558 10.8389 15.7231 10.8394 15.7153L10.8395 15.7147C10.8412 15.6925 10.8419 15.6739 10.8421 15.6678C10.8427 15.6511 10.8431 15.6332 10.8433 15.6186C10.8439 15.5873 10.8443 15.5438 10.8447 15.4903C10.8455 15.3823 10.8462 15.2221 10.8467 15.0106C10.8478 14.5871 10.8485 13.9526 10.8486 13.1075C10.8489 11.4171 10.8472 8.88149 10.8437 5.50099ZM7.32549 13.9496C7.32551 13.9492 7.32779 13.9504 7.33231 13.9545C7.32774 13.952 7.32548 13.95 7.32549 13.9496Z"
                fill="currentColor"
            />
        """);
builder.CloseElement();
};
Label ="finger_left_stroked";
        base.OnInitialized();
    }
}
