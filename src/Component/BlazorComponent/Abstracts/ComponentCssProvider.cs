namespace BlazorComponent;

public class ComponentCssProvider
{
    private readonly List<string> _cssConfig = new();
    private readonly List<string> _styleConfig = new();

    /// <summary>
    /// Apply css to named element
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public ComponentCssProvider CssApply(string name)
    {
        _cssConfig.Add(name);
        return this;
    }

    /// <summary>
    /// Apply css to named element
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public ComponentCssProvider StyleApply(string name)
    {
        _styleConfig.Add(name);
        return this;
    }

    /// <summary>
    /// remove css 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public ComponentCssProvider Remove(string name)
    {
        _cssConfig.Remove(name);
        _styleConfig.Remove(name);

        return this;
    }

    /// <summary>
    /// Get class of default element
    /// </summary>
    /// <returns></returns>
    public string GetClass()
        => string.Join(' ', _cssConfig);

    /// <summary>
    /// Get style of default element
    /// </summary>
    /// <returns></returns>
    public string GetStyle()
        => string.Join(' ', _styleConfig);
}