namespace Semi.Design.Blazor;
public class SIconPuzzle : SIcon
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
                d="M14.6632 5C14.8792 4.54537 15 4.0368 15 3.5C15 1.567 13.433 0 11.5 0C9.567 0 8 1.567 8 3.5C8 4.0368 8.12085 4.54537 8.33682 5H5C3.89543 5 3 5.89543 3 7V10.3368C3.45463 10.1208 3.9632 10 4.5 10C6.433 10 8 11.567 8 13.5C8 15.433 6.433 17 4.5 17C3.9632 17 3.45463 16.8792 3 16.6632V21C3 22.1046 3.89543 23 5 23H18C19.1046 23 20 22.1046 20 21V16.9646C20.1633 16.9879 20.3302 17 20.5 17C22.433 17 24 15.433 24 13.5C24 11.567 22.433 10 20.5 10C20.3302 10 20.1633 10.0121 20 10.0354V7C20 5.89543 19.1046 5 18 5H14.6632Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "puzzle";
        base.OnInitialized();
    }
}
