using BlazorComponent;
using Microsoft.AspNetCore.Components;
using Semi.Design.CodeRendering;

namespace Semi.Design.Shared;

public partial class MonacoEditor 
{
    
    [Inject]
    public required IHttpClientFactory httpClientFactory { get; set; }
    
    [Parameter]
    public string Component { get; set; }

    private ElementReference _ref;
    private ElementReference? _prevRef;
    private bool _elementReferenceChanged;

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

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public async Task InitComplete()
    {
        await GetCode();
    }

    private object InitMonaco()
    {
        return new
        {
            language = "razor",
            value = "<div></div>",
            theme = "vs-dark"
        };
    }

    

    private async Task GetCode()
    {
        var client = httpClientFactory.CreateClient("docs");
        try
        {

            var value = await client.GetStringAsync("_content/Semi.Design.Shared/pages/" + Component);

            _monacoEditor?.SetValue(value);
        }
        catch
        {
        }
    }
}