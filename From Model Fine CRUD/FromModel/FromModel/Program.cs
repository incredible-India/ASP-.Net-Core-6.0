using FromModel.Repositories;
using FromModel.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(options => options.EnableEndpointRouting =false);
builder.Services.AddSingleton<IStudent, studentservice>();
var app = builder.Build();

app.UseMvcWithDefaultRoute();
app.UseStaticFiles();

/*app.MapGet("/", () => "Hello World!");*/

app.Run();
