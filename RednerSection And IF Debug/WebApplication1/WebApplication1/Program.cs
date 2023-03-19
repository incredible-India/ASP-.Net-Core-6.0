using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
#if DEBUG
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
#endif

var app = builder.Build();
app.UseMvcWithDefaultRoute();
/*app.MapGet("/", () => "Hello World!");*/

app.Run();
