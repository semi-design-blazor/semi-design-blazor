namespace Semi.Design.Blazor;

public partial class SDivider
{
    [Parameter]
    public string? Align { get; set; } = "center";

    [Parameter]
    public string? Margin { get; set; }

    [Parameter]
    public bool Dashed { get; set; }

    [Parameter]
    public string? Layout { get; set; }

    /// <summary>
    /// 当前组件的前缀
    /// </summary>
    private const string PrefixCls = "semi-divider";

    protected override void OnInitialized()
    {
        ComponentProvider.CssApply(PrefixCls);
        if (string.IsNullOrEmpty(Layout))
        {
            Layout = "horizontal";
        }

        if (Layout != "vertical")
        {
            ComponentProvider.CssApply(PrefixCls + "-horizontal");
        }

        if (Dashed == true)
        {
            ComponentProvider.CssApply(PrefixCls + "-dashed");
        }
        if (ChildContent != null && Layout == "horizontal")
        {
            ComponentProvider.CssApply(PrefixCls + "-with-text");
            ComponentProvider.CssApply(PrefixCls + "-with-text-" + Align);
        }

        if (!string.IsNullOrEmpty(Margin))
        {
            if (Layout == "vertical")
            {
                ComponentProvider.CssApply(PrefixCls + "-vertical");
                ComponentProvider.StyleApply("margin-left:" + Margin);
                ComponentProvider.StyleApply("margin-right:" + Margin);
            }
            else if (Layout == "horizontal")
            {
                ComponentProvider.CssApply(PrefixCls + "-horizontal");
                ComponentProvider.StyleApply("margin-top:" + Margin);
                ComponentProvider.StyleApply("margin-bottom:" + Margin);
            }
        }

        base.OnInitialized();
    }
}