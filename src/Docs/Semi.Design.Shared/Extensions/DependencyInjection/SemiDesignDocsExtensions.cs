using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Semi.Design.Blazor.Languages.Razor;
using Semi.Design.Blazor.Monaco.Editor;
using Semi.Design.CodeRendering;
using Token.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class SemiDesignDocsExtensions
{
    public static async void AddSemiDesignDocs(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("docs");

        _ = Task.Run(() =>
        {
            RazorCompile.Initialized(GetReference(), GetRazorExtension());
        });

        services.AddSemiDesignMonaco();
        services.AddSemiDesignBlazor();
        services.AddEventBus();

        // 添加动态编译时全局引用
        CompileRazorProjectFileSystem.AddGlobalUsing("@using Semi.Design.Blazor");
    }

    private static List<string> Assemblys = new()
    {
        "System.IO",
        "System.Diagnostics.Process"
    };

    static List<PortableExecutableReference> GetReference()
    {
        var portableExecutableReferences = new List<PortableExecutableReference>();
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            try
            {
                if (Assemblys.Any(x => x == asm.GetName().Name))
                {
                    continue;
                }

                portableExecutableReferences?.Add(MetadataReference.CreateFromFile(asm.Location));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return portableExecutableReferences;
    }

    static List<RazorExtension> GetRazorExtension()
    {
        var razorExtension = new List<RazorExtension>();

        foreach (var asm in typeof(SemiDesignDocsExtensions).Assembly.GetReferencedAssemblies())
        {
            razorExtension.Add(new AssemblyExtension(asm.FullName, AppDomain.CurrentDomain.Load(asm.FullName)));
        }

        return razorExtension;
    }
}
