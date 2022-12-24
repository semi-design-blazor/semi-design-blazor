using Microsoft.Extensions.Configuration;
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
        services.AddSemiDesignBlazor();
        services.AddEventBus();
    }

}
