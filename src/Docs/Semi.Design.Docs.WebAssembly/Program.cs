using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Semi.Design.CodeRendering;
using Semi.Design.CodeRendering.Extensions;
using Semi.Design.Docs.WebAssembly;
using Environment = Semi.Design.CodeRendering.Environment;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSemiDesignDocs(builder.Configuration);
builder.Services.AddSemiDesignCodeRendering(Environment.WebAssembly);

var app = builder.Build();

await CodeRendering.InitializedAsync(app.Services);

await app.RunAsync();