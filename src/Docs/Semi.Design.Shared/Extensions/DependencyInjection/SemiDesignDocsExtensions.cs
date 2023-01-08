using Microsoft.Extensions.Configuration;
using Semi.Design.CodeRendering;
using Semi.Design.CodeRendering.Extensions;
using Token.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class SemiDesignDocsExtensions
{
    public static void AddSemiDesignDocs(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("docs", options =>
        {
#if DEBUG
            options.BaseAddress = new Uri(configuration["Urls"]);
#else
            options.BaseAddress = new Uri("http://127.0.0.1:80");
#endif

        });

        services.AddSemiDesignCodeRendering();
        services.AddSemiDesignBlazor();
        services.AddEventBus();

        // 添加动态编译时全局引用
        CodeRenderingProject.GlobalUsing += Environment.NewLine+ "@using Semi.Design.Blazor";
    }

}
