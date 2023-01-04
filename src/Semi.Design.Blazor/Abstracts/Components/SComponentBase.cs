using Microsoft.JSInterop;

namespace Semi.Design.Blazor;

public abstract class SComponentBase : ComponentBase
{
    [Inject] public virtual required IJSRuntime Js { get; set; }

    protected async Task<T> JsInvokeAsync<T>(string code, params object[] args)
    {
        return await Js.InvokeAsync<T>(code, args);
    }

    protected async Task JsInvokeAsync(string code, params object[] args)
    {
        await Js.InvokeVoidAsync(code, args);
    }
}