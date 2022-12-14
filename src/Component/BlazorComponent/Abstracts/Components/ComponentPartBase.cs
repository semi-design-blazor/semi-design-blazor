using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorComponent
{
    public class ComponentPartBase<TComponent> : IComponentPart where TComponent : IHasProviderComponent
    {
        public TComponent Component { get; set; }

        protected ComponentCssProvider CssProvider => Component.CssProvider;

        RenderFragment IComponentPart.Content => BuildRenderTree;

        void IComponentPart.Attach(IHasProviderComponent hasProviderComponent)
        {
            if (hasProviderComponent is TComponent component)
            {
                Component = component;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        void IComponentPart.SetParameters(ParameterView parameterView)
        {
            parameterView.SetParameterProperties(this);
        }

        protected RenderFragment RenderText(object text)
        {
            return builder => builder.AddContent(0, text);
        }
        
        protected EventCallback<TValue> CreateEventCallback<TValue>(Func<TValue, Task> callback)
        {
            return EventCallback.Factory.Create(Component, callback);
        }

        protected virtual void BuildRenderTree(RenderTreeBuilder builder)
        {
        }
    }
}
