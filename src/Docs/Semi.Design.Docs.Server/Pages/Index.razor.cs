using Microsoft.AspNetCore.Components;

namespace Semi.Design.Docs.Server.Pages;

public partial class Index
{
    /// <summary>
    /// 加载指定组件
    /// </summary>
    [Parameter]
    public string? Path { get; set; }
}
