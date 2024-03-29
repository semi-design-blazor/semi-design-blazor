namespace Semi.Design.Blazor;
public class SIconFacebook : SIcon
{
    protected override void OnInitialized()
    {
        Svg = builder =>
        {
            builder.OpenElement(0, "svg");
            builder.AddAttribute(1, "viewBox", "0 0 24 24");
            builder.AddAttribute(2, "fill", "none");
            builder.AddAttribute(3, "xmlns", "http://www.w3.org/2000/svg");
            builder.AddAttribute(4, "width", "1em");
            builder.AddAttribute(5, "height", "1em");
            builder.AddAttribute(6, "focusable", "false");
            builder.AddAttribute(7, "aria-hidden", "true");
            builder.AddMarkupContent(8, """
            <path
                d="M20.8889 2H3.11111C2.49667 2 2 2.49778 2 3.11111V20.8889C2 21.5022 2.49667 22 3.11111 22H12.6833V14.2667H10.0856V11.2389H12.6833V9.01667C12.6833 6.43333 14.2611 5.02556 16.5722 5.02556C17.3489 5.02333 18.1267 5.06333 18.9 5.14444V7.83333H17.3056C16.0522 7.83333 15.8078 8.43111 15.8078 9.30556V11.2333H18.8044L18.4156 14.2611H15.8067V22H20.8889C21.5033 22 22 21.5022 22 20.8889V3.11111C22 2.49778 21.5033 2 20.8889 2Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "facebook";
        base.OnInitialized();
    }
}
