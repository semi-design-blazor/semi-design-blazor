using Microsoft.Extensions.Configuration;
using Semi.Design.Shared.Component.MonacoEditor;
using Token.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class SemiDesignDocsExtensions
{
    public static void AddSemiDesignDocs(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("docs", options =>
        {
            options.BaseAddress = new Uri(configuration["Urls"]);
        });
        services.AddScoped<MonacoEditorJSModule>();
        services.AddSemiDesignBlazor();
        services.AddEventBus();
    }

}
