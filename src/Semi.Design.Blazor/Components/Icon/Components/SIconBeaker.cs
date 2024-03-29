namespace Semi.Design.Blazor;
public class SIconBeaker : SIcon
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
                d="M6.99995 9.63222V4C6.17155 3.99997 5.5 3.32841 5.5 2.5C5.5 1.67157 6.17157 1 7 1H8.49995H15.5H17C17.8284 1 18.5 1.67157 18.5 2.5C18.5 3.32843 17.8284 4 17 4H17V9.63222L22.0668 19.3436C22.9351 21.008 21.7276 23 19.8503 23H4.14962C2.27229 23 1.06476 21.008 1.93315 19.3436L6.99995 9.63222ZM14 4H9.99995V10C9.99995 10.2416 9.94159 10.4796 9.82983 10.6938L8.62662 13H15.3733L14.1701 10.6938C14.0583 10.4796 14 10.2416 14 10V4Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "beaker";
        base.OnInitialized();
    }
}
