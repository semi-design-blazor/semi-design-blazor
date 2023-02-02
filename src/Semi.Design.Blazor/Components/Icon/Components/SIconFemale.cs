namespace Semi.Design.Blazor;
public class SIconFemale : SIcon
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
                d="M10.5 9C10.5 6.51472 12.5147 4.5 15 4.5C17.4853 4.5 19.5 6.51472 19.5 9C19.5 11.4853 17.4853 13.5 15 13.5C12.5147 13.5 10.5 11.4853 10.5 9ZM15 1.5C10.8579 1.5 7.50003 4.85786 7.50003 9C7.50003 10.5369 7.96228 11.9657 8.75534 13.1552L7.08624 14.8243L5.15099 12.8891C4.56521 12.3033 3.61546 12.3033 3.02967 12.8891C2.44389 13.4748 2.44389 14.4246 3.02967 15.0104L4.96492 16.9456L3.05652 18.854C2.47073 19.4398 2.47073 20.3896 3.05652 20.9754C3.64231 21.5611 4.59205 21.5611 5.17784 20.9754L7.08624 19.0669L9.02155 21.0023C9.60733 21.588 10.5571 21.588 11.1429 21.0023C11.7287 20.4165 11.7287 19.4667 11.1429 18.8809L9.20756 16.9456L10.8831 15.2701C12.0649 16.0476 13.4796 16.5 15 16.5C19.1422 16.5 22.5 13.1421 22.5 9C22.5 4.85786 19.1422 1.5 15 1.5Z"
                fill="currentColor"
            />
        """);
            builder.CloseElement();
        };
        Label = "female";
        base.OnInitialized();
    }
}
