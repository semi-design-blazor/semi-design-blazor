namespace Semi.Design.Blazor;
public class SIconPaperclip : SIcon
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
                fillRule="evenodd"
                clipRule="evenodd"
                d="M18.273 4.27297C17.2423 3.24234 15.5714 3.24234 14.5407 4.27297L6.79074 12.023C5.06975 13.744 5.06975 16.5342 6.79074 18.2552C8.51172 19.9762 11.302 19.9762 13.023 18.2552L18.523 12.7552C19.0111 12.267 19.8026 12.267 20.2907 12.7552C20.7789 13.2434 20.7789 14.0348 20.2907 14.523L14.7907 20.023C12.0934 22.7203 7.72027 22.7203 5.02297 20.023C2.32568 17.3257 2.32568 12.9525 5.02297 10.2552L12.773 2.5052C14.7799 0.498263 18.0338 0.498268 20.0407 2.5052C22.0477 4.51214 22.0477 7.76603 20.0407 9.77297L12.7907 17.023C11.4742 18.3396 9.33955 18.3396 8.02297 17.023C6.70639 15.7064 6.70639 13.5718 8.02297 12.2552L13.523 6.7552C14.0111 6.26705 14.8026 6.26705 15.2907 6.7552C15.7789 7.24336 15.7789 8.03482 15.2907 8.52297L9.79074 14.023C9.45047 14.3632 9.45047 14.9149 9.79074 15.2552C10.131 15.5955 10.6827 15.5955 11.023 15.2552L18.273 8.0052C19.3036 6.97458 19.3036 5.3036 18.273 4.27297Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "paperclip";
        base.OnInitialized();
    }
}
