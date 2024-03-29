namespace Semi.Design.Blazor;
public class SIconFlipHorizontal : SIcon
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
                d="M11 3C11 2.39676 10.5692 1.87958 9.97588 1.77058C9.38257 1.66157 8.79606 1.99184 8.58164 2.55569L1.83164 20.3057C1.68555 20.6898 1.73764 21.1213 1.97096 21.4596C2.20428 21.798 2.58901 22 3.00001 22H9.75001C10.4404 22 11 21.4404 11 20.75V3ZM8.50001 19.5H4.81269L8.50001 9.80373V19.5Z"
                fill="currentColor"
            />
            <path
                d="M14.0241 1.77058C13.4308 1.87958 13 2.39676 13 3V20.75C13 21.4404 13.5596 22 14.25 22H21C21.411 22 21.7957 21.798 22.029 21.4596C22.2624 21.1213 22.3145 20.6898 22.1684 20.3057L15.4184 2.55569C15.2039 1.99184 14.6174 1.66157 14.0241 1.77058Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "flip_horizontal";
        base.OnInitialized();
    }
}
