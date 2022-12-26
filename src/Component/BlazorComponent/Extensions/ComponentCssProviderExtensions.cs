namespace BlazorComponent.Extensions;

internal static class ComponentCssProviderExtensions
{
    public static ComponentCssProvider ApplyClassNameIf(this ComponentCssProvider self, bool ret, string className)
    {
        if(ret)
            self.CssApply(className);
        return self;
    }
    
    public static ComponentCssProvider ApplyStyleIf(this ComponentCssProvider self, bool ret, string style)
    {
        if(ret)
            self.StyleApply(style);
        return self;
    }
}