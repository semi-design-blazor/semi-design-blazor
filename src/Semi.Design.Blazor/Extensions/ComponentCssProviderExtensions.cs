namespace Semi.Design.Blazor.Extensions;

internal static class ComponentCssProviderExtensions
{
    public static ComponentProvider ApplyClassNameIf(this ComponentProvider self, bool ret, string className)
    {
        if(ret)
            self.CssApply(className);
        return self;
    }
    
    public static ComponentProvider ApplyStyleIf(this ComponentProvider self, bool ret, string style)
    {
        if(ret)
            self.StyleApply(style);
        return self;
    }
}