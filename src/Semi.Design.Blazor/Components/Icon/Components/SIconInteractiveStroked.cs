namespace Semi.Design.Blazor;
public class SIconInteractiveStroked : SIcon
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
                d="M12.5 22C18.0228 22 22.5 17.5228 22.5 12C22.5 6.47715 18.0228 2 12.5 2C6.97715 2 2.5 6.47715 2.5 12C2.5 17.5228 6.97715 22 12.5 22ZM20.6818 12C20.6818 16.5187 17.0187 20.1818 12.5 20.1818C7.98131 20.1818 4.31818 16.5187 4.31818 12C4.31818 7.48131 7.98131 3.81818 12.5 3.81818C17.0187 3.81818 20.6818 7.48131 20.6818 12ZM18.8636 12C18.8636 15.5145 16.0145 18.3636 12.5 18.3636C8.98546 18.3636 6.13636 15.5145 6.13636 12C6.13636 8.48546 8.98546 5.63636 12.5 5.63636C16.0145 5.63636 18.8636 8.48546 18.8636 12ZM12.5 16.5455C15.0104 16.5455 17.0455 14.5104 17.0455 12C17.0455 9.48961 15.0104 7.45455 12.5 7.45455C9.98961 7.45455 7.95455 9.48961 7.95455 12C7.95455 14.5104 9.98961 16.5455 12.5 16.5455ZM15.2273 12C15.2273 13.5062 14.0062 14.7273 12.5 14.7273C10.9938 14.7273 9.77273 13.5062 9.77273 12C9.77273 10.4938 10.9938 9.27273 12.5 9.27273C14.0062 9.27273 15.2273 10.4938 15.2273 12Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "interactive_stroked";
        base.OnInitialized();
    }
}
