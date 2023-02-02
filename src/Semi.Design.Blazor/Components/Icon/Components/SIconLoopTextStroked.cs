namespace Semi.Design.Blazor;
public class SIconLoopTextStroked : SIcon
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
                d="M19.6402 2.23177C19.2159 1.87821 18.5853 1.93553 18.2318 2.35981C17.8782 2.78409 17.9355 3.41465 18.3598 3.76822L19.238 4.5H8C4.14834 4.5 1 7.62032 1 11.5C1 12.0523 1.44772 12.5 2 12.5C2.55228 12.5 3 12.0523 3 11.5C3 8.72988 5.2479 6.5 8 6.5H19.2379L18.3598 7.23177C17.9355 7.58534 17.8782 8.2159 18.2318 8.64018C18.5853 9.06446 19.2159 9.12178 19.6402 8.76822L22.6335 6.27377C22.8572 6.09037 23 5.81186 23 5.49999C23 5.25886 22.913 5.02785 22.758 4.84779C22.7266 4.81121 22.6923 4.77674 22.6554 4.74471C22.6485 4.7387 22.6415 4.73278 22.6344 4.72696L19.6402 2.23177ZM22 11C22.5523 11 23 11.4477 23 12C23 15.8797 19.8517 19 16 19H4.76206L5.64018 19.7318C6.06446 20.0853 6.12179 20.7159 5.76822 21.1402C5.41466 21.5645 4.78409 21.6218 4.35982 21.2682L1.36616 18.7735C1.35303 18.7627 1.34018 18.7516 1.32762 18.7402C1.30033 18.7154 1.27441 18.6891 1.25 18.6615C1.09441 18.4852 1 18.2536 1 18C1 17.7456 1.09496 17.5135 1.25136 17.337C1.27461 17.3108 1.29933 17.2856 1.32545 17.2618C1.33839 17.2499 1.35165 17.2384 1.3652 17.2273L4.35982 14.7318C4.78409 14.3782 5.41466 14.4355 5.76822 14.8598C6.12179 15.2841 6.06446 15.9147 5.64018 16.2682L4.76204 17H16C18.7521 17 21 14.7701 21 12C21 11.4477 21.4477 11 22 11ZM7 9.5C7 9.22386 7.22386 9 7.5 9H13.5C13.7761 9 14 9.22386 14 9.5V10.5C14 10.7761 13.7761 11 13.5 11H7.5C7.22386 11 7 10.7761 7 10.5V9.5ZM15.5 9C15.2239 9 15 9.22386 15 9.5V10.5C15 10.7761 15.2239 11 15.5 11H17.5C17.7761 11 18 10.7761 18 10.5V9.5C18 9.22386 17.7761 9 17.5 9H15.5ZM7 13.5C7 13.2239 7.22386 13 7.5 13H10.5C10.7761 13 11 13.2239 11 13.5V14.5C11 14.7761 10.7761 15 10.5 15H7.5C7.22386 15 7 14.7761 7 14.5V13.5ZM12.5 13C12.2239 13 12 13.2239 12 13.5V14.5C12 14.7761 12.2239 15 12.5 15H17.5C17.7761 15 18 14.7761 18 14.5V13.5C18 13.2239 17.7761 13 17.5 13H12.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "loop_text_stroked";
        base.OnInitialized();
    }
}
