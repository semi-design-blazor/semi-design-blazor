
namespace BlazorComponent
{
    public interface IHasProviderComponent : IComponent, IHandleAfterRender
    {
        ComponentCssProvider CssProvider { get; }
    }
}