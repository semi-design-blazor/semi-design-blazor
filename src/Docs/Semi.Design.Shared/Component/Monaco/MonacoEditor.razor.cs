using Microsoft.AspNetCore.Components;
using Semi.Design.CodeRendering;

namespace Semi.Design.Shared;

public partial class MonacoEditor
{
    [Inject]
    public required IHttpClientFactory httpClientFactory { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Parameter]
    public string Component { get; set; }

    [Parameter]
    public Type? ComponentType { get; set; }

    private ElementReference _ref;
    private ElementReference? _prevRef;
    private bool _elementReferenceChanged;
    private SMonacoEditor? _sMonacoEditor;

    public SMonacoEditor? _monacoEditor;

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

    public async Task InitComplete()
    {
        await GetCode();
    }


    private (string, string[], CompletionItem[]) RegisterCompletionItemProvider()
    {
        var trigger = new[]
        {
            "<S"
        };
        var completionItems = new CompletionItem[]
        {
            new("SButton", CompletionItemKind.Function, "按钮组件", "", "", "", true, "<SButton></SButton>")
        };
        return ("razor", trigger, completionItems);
    }

    private async Task GetCode()
    {
        // 组件名称
        var type = "Semi.Design.Shared.Component." + Component.Replace("/", ".").Replace(".txt", "");
        ComponentType = typeof(MonacoEditor).Assembly.GetTypes().FirstOrDefault(x => x.FullName == type);
        StateHasChanged();
    }

    private async Task<object?> MonacoAsync()
    {
        var client = httpClientFactory.CreateClient("docs");
        try
        {
            var value = await client.GetStringAsync(NavigationManager.BaseUri + "_content/Semi.Design.Shared/pages/" + (Component.EndsWith(".txt") ? Component : Component + ".txt"));

            return new
            {
                language = "razor",
                value,
                theme = "vs-dark"
            };

        }
        catch (Exception)
        {
            return null;
        }
    }

    private async Task RunCode()
    {
        // 执行代码渲染
        var code = await _sMonacoEditor?.GetValue();
        _ = Task.Run(() =>
        {
            ComponentType = CodeRenderingHelper.RenderingToType(code);
            _ = InvokeAsync(StateHasChanged);
        });
    }
}