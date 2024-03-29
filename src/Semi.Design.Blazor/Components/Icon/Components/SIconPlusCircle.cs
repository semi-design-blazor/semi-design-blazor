namespace Semi.Design.Blazor;
public class SIconPlusCircle : SIcon
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
                d="M12 23C18.0751 23 23 18.0751 23 12C23 5.92487 18.0751 1 12 1C5.92487 1 1 5.92487 1 12C1 18.0751 5.92487 23 12 23ZM18.9988 11.8778C19.0132 12.7061 18.3535 13.3893 17.5252 13.4038L13.5258 13.4736L13.5956 17.473C13.61 18.3013 12.9503 18.9845 12.122 18.9989C11.2937 19.0134 10.6105 18.3537 10.596 17.5254L10.5262 13.526L6.52684 13.5958C5.69854 13.6102 5.01535 12.9505 5.00089 12.1222C4.98644 11.2939 5.64619 10.6107 6.47449 10.5962L10.4739 10.5264L10.4041 6.52703C10.3896 5.69873 11.0494 5.01553 11.8777 5.00108C12.706 4.98662 13.3892 5.64637 13.4036 6.47467L13.4734 10.4741L17.4728 10.4043C18.3011 10.3898 18.9843 11.0495 18.9988 11.8778Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "plus_circle";
        base.OnInitialized();
    }
}
