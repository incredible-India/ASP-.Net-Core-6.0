using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc(options=>options.EnableEndpointRouting = false);

var app = builder.Build();
app.UseMvcWithDefaultRoute();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "myimg")),
    RequestPath = "/myimg"

}) ;
//app.MapGet("/", () => "Hello World!");

app.Run();
