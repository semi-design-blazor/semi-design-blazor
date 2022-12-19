using Microsoft.JSInterop;

namespace Semi.Design.Blazor;

public class HelperJsInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public HelperJsInterop(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Semi.Design.Blazor/js/helper.js").AsTask());
    }

    public async ValueTask SetTheme(string theme)
    {
        var module = await moduleTask.Value;
        await module.InvokeAsync<string>("setTheme", theme);
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
