using Semi.Design.CodeRendering;
using Semi.Design.CodeRendering.Extensions;
using Environment = Semi.Design.CodeRendering.Environment;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor();
builder.Services.AddSemiDesignDocs(builder.Configuration);
builder.Services.AddSemiDesignCodeRendering(Environment.Server);

_ = CodeRenderingHelper.InitializedAsync(builder.Services.BuildServiceProvider());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
