namespace Semi.Design.Blazor;
public class SIconMoreStroked : SIcon
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
                d="M7.5 12C7.5 13.3807 6.38071 14.5 5 14.5C3.61929 14.5 2.5 13.3807 2.5 12C2.5 10.6193 3.61929 9.5 5 9.5C6.38071 9.5 7.5 10.6193 7.5 12Z"
                fill="currentColor"
            />
            <path
                d="M15 12C15 13.3807 13.8807 14.5 12.5 14.5C11.1193 14.5 10 13.3807 10 12C10 10.6193 11.1193 9.5 12.5 9.5C13.8807 9.5 15 10.6193 15 12Z"
                fill="currentColor"
            />
            <path
                d="M20 14.5C21.3807 14.5 22.5 13.3807 22.5 12C22.5 10.6193 21.3807 9.5 20 9.5C18.6193 9.5 17.5 10.6193 17.5 12C17.5 13.3807 18.6193 14.5 20 14.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "more_stroked";
        base.OnInitialized();
    }
}
