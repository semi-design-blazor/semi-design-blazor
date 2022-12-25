using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;

namespace BlazorComponent.Extensions;

public static class RenderFragmentExtensions
{
    public static bool IsString(this RenderFragment self)
    {
        if (self is null)
            return false;
        
        var builder = new RenderTreeBuilder();
        builder.AddContent(0, self);
        var frameTypes = new[] { RenderTreeFrameType.Text, RenderTreeFrameType.Markup };
        var frame = builder.GetFrames().Array.FirstOrDefault(x => frameTypes.Any(t=> t== x.FrameType));
        return !string.IsNullOrWhiteSpace(frame.MarkupContent) && !IsHtml(frame.MarkupContent);
    }

    public static bool IsSemiIcon(this RenderFragment self)
    {
        if (self is null)
            return false;
        
        var builder = new RenderTreeBuilder();
        builder.AddContent(0, self);
        var frame = builder.GetFrames().Array.FirstOrDefault(x => RenderTreeFrameType.Component == x.FrameType);
        return typeof(SIcon).IsAssignableFrom(frame.ComponentType);
    }

    private const string Pattern = @"<[a-z]+\d?(\s+[\w-]+=(""[^""]*""|'[^']*'))*\s*\/?>|&#?\w+;";
    private static bool IsHtml(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;
        
        var regex = new Regex(Pattern);
        return regex.IsMatch(text);
    }
}