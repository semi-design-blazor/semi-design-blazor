using Microsoft.Extensions.Configuration;
using Semi.Design.CodeRendering;
using Semi.Design.CodeRendering.Extensions;
using Semi.Design.CodeRendering.Rendering.Options;
using Token.Extensions;
using Environment = Semi.Design.CodeRendering.Environment;

namespace Microsoft.Extensions.DependencyInjection;

public static class SemiDesignDocsExtensions
{
    public static void AddSemiDesignDocs(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("docs");

        services.AddSemiDesignCodeRendering(Environment.Server);
        services.AddSemiDesignBlazor();
        services.AddEventBus();

        // 添加动态编译时全局引用
        CodeRenderingProject.GlobalUsing = "@using Semi.Design.Blazor";
    }

}
