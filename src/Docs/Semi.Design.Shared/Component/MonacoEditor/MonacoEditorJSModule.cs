using Semi.Design.Shared;
using Microsoft.JSInterop;

namespace Semi.Design.Shared.Component.MonacoEditor;

public class MonacoEditorJSModule : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public MonacoEditorJSModule(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Semi.Design.Shared/js/editor.js").AsTask());
    }

    public async ValueTask<IJSObjectReference> Init(string id, EditorOptions options)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<IJSObjectReference>("init", id, options);
    }

    public async ValueTask<string> GetValue(IJSObjectReference id)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("getValue", id);
    }

    public async ValueTask SetValue(IJSObjectReference id, string value)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setValue", id, value);
    }

    public async ValueTask SetTheme(string theme)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setTheme", theme);
    }

    public async ValueTask<TextModelOptions[]> GetModels()
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<TextModelOptions[]>("getModels");
    }

    public async ValueTask<TextModelOptions> GetModel(IJSObjectReference id)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<TextModelOptions>("getModel", id);
    }

    public async ValueTask SetModelLanguage(IJSObjectReference id, string languageId)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setModelLanguage", id, languageId);
    }

    public async ValueTask RemeasureFonts()
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("remeasureFonts");
    }

    public async ValueTask AddKeybindingRules(KeybindingRule[] rules)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("addKeybindingRules", rules);
    }

    public async ValueTask AddKeybindingRule(KeybindingRule rule)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("addKeybindingRules", rule);
    }

    public async ValueTask DisposeAsync()
    {
        moduleTask.Value.Dispose();
        await Task.CompletedTask;
    }
}