using Semi.Design.Blazor.Options;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSemiDesignBlazor(this IServiceCollection services)
    {
        return services.AddSemiDesignBlazorInternal();
    }

    public static IServiceCollection AddSemiDesignBlazor(this IServiceCollection services, Action<SemiDesignBlazorOptions> optionsAction)
    {
        return services.AddSemiDesignBlazorInternal();
    }

    private static IServiceCollection AddSemiDesignBlazorInternal(this IServiceCollection services)
    {

        return services;
    }
}
