namespace Semi.Design.Blazor;
public class SIconTestScoreStroked : SIcon
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
                d="M5 1C3.89543 1 3 1.89543 3 3V21C3 22.1046 3.89543 23 5 23H19C20.1046 23 21 22.1046 21 21V3C21 1.89543 20.1046 1 19 1H5ZM5 3L19 3V21H5V3ZM8 17C7.44772 17 7 17.4477 7 18C7 18.5523 7.44772 19 8 19H16C16.5523 19 17 18.5523 17 18C17 17.4477 16.5523 17 16 17H8ZM7 14C7 13.4477 7.44772 13 8 13H16C16.5523 13 17 13.4477 17 14C17 14.5523 16.5523 15 16 15H8C7.44772 15 7 14.5523 7 14ZM10.2502 4.5C10.5342 4.5 10.7939 4.6605 10.921 4.91459L13.421 9.91459C13.6062 10.2851 13.4561 10.7356 13.0856 10.9208C12.7151 11.1061 12.2646 10.9559 12.0793 10.5854L11.6616 9.75H8.83869L8.42098 10.5854C8.23574 10.9559 7.78524 11.1061 7.41475 10.9208C7.04427 10.7356 6.8941 10.2851 7.07934 9.91459L9.57934 4.91459C9.70639 4.6605 9.96608 4.5 10.2502 4.5ZM10.2502 6.92705L10.9116 8.25H9.58869L10.2502 6.92705Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "test_score_stroked";
        base.OnInitialized();
    }
}
