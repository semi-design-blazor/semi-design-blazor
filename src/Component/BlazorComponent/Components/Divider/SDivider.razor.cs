namespace BlazorComponent;

public partial class SDivider
{
    [Parameter] public string? Align { get; set; } = "center";

    [Parameter] 
    public string? Margin { get; set; }

    [Parameter] 
    public bool Dashed { get; set; }

    [Parameter] 
    public string Layout { get; set; } = "horizontal";

    private const string PrefixCls = "semi-divider";

    protected override void OnInitialized()
    {
        CssProvider.CssApply(PrefixCls);
        CssProvider.CssApply(PrefixCls + "-horizontal");
        CssProvider.CssApply(PrefixCls + "-vertical");
        if (Dashed == false)
        {
            CssProvider.CssApply(PrefixCls + "-dashed");
        }
        if (ChildContent != null && Layout == "horizontal")
        {
            CssProvider.CssApply(PrefixCls + "-with-text");
            CssProvider.CssApply(PrefixCls + "-with-text-" + Align);
        }

        if (!string.IsNullOrEmpty(Margin))
        {
            if (Layout == "vertical")
            {
                CssProvider.StyleApply("margin-left:" + Margin);
                CssProvider.StyleApply("margin-right:" + Margin);
            }
            else if(Layout == "horizontal")
            {
                CssProvider.StyleApply("margin-top:" + Margin);
                CssProvider.StyleApply("margin-bottom:" + Margin);
            }
        }

        base.OnInitialized();
    }
}