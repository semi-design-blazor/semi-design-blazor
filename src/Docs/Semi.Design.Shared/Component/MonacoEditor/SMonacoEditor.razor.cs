using BlazorComponent;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Semi.Design.Shared.Component.MonacoEditor;

namespace Semi.Design.Shared;

public partial class SMonacoEditor : SDomComponentBase, IAsyncDisposable
{
    [Inject]
    protected MonacoEditorJSModule Module { get; set; }

    [Inject]
    public required IHttpClientFactory httpClientFactory { get; set; }

    [Parameter]
    public EditorOptions EditorOptions { get; set; } = new();

    [Parameter]
    public string Width { get; set; } = "500px";

    [Parameter]
    public string Height { get; set; } = "300px";

    [Parameter]
    public string Component { get; set; }

    private ElementReference _ref;
    private ElementReference? _prevRef;
    private bool _elementReferenceChanged;

    public virtual ElementReference Ref
    {
        get => _ref;
        set
        {
            if (_prevRef.HasValue)
            {
                if (_prevRef.Value.Id != value.Id)
                {
                    _prevRef = value;
                    _elementReferenceChanged = true;
                }
            }
            else
            {
                _prevRef = value;
            }

            _ref = value;
        }
    }

    private IJSObjectReference _monaco;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await InitMonaco();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    protected override void OnInitialized()
    {
        CssProvider.StyleApply("width:" + Width)
            .StyleApply("height:" + Height);
        base.OnInitialized();
    }

    private async void GetCode()
    {
        var client = httpClientFactory.CreateClient("docs");
        try
        {

            var value = await client.GetStringAsync("_content/Semi.Design.Shared/pages/" + Component);
            if (!string.IsNullOrEmpty(value))
            {
                SetValue(value);
            }
        }
        catch
        {
        }
    }

    public async Task InitMonaco()
    {
        _monaco = await Module.Init(Id, EditorOptions);
        GetCode();
    }

    public async Task<string> GetValue()
    {
        return await Module.GetValue(_monaco);
    }

    public async void SetModelLanguage(string language)
    {
        await Module.SetModelLanguage(_monaco, language);
    }

    public async void SetValue(string newValue)
    {
        await Module.SetValue(_monaco, newValue);
    }

    public async void SetTheme(string newTheme)
    {
        await Module.SetTheme(newTheme);
    }

    public async Task<TextModelOptions[]> GetModels()
    {
        return await Module.GetModels();
    }

    public async Task<TextModelOptions> GetModel()
    {
        return await Module.GetModel(_monaco);
    }

    public async void RemeasureFonts()
    {
        await Module.RemeasureFonts();
    }

    public async void AddKeybindingRules(KeybindingRule[] rules)
    {
        await Module.AddKeybindingRules(rules);
    }

    public async void AddKeybindingRules(KeybindingRule rule)
    {
        await Module.AddKeybindingRule(rule);
    }


    public async ValueTask DisposeAsync()
    {
        try
        {
            await Task.CompletedTask;
        }
        catch
        {
            // ignored
        }
    }
}