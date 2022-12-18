using Semi.Design.Docs.Server.Options;
using System.Text.Json;

namespace Microsoft.Extensions.DependencyInjection;

public static class SemiDesignDocsExtensions
{
    public static void AddSemiDesignDocs(this IServiceCollection services)
    {
        services.ConfigreNavigation();
    }

    /// <summary>
    /// 加载菜单数据
    /// </summary>
    /// <param name="services"></param>
    private static void ConfigreNavigation(this IServiceCollection services)
    {
        var navigation = JsonSerializer.Deserialize<Navigation>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "wwwroot", "navigation.json")), new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            AllowTrailingCommas = true,
        });
        services.AddSingleton(navigation!);
    }
}
