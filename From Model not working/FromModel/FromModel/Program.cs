using FromModel.Repositories;
using FromModel.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(options => options.EnableEndpointRouting =false);
builder.Services.AddTransient<IStudent, studentservice>();
var app = builder.Build();

app.UseMvcWithDefaultRoute();
app.UseStaticFiles();

/*app.MapGet("/", () => "Hello World!");*/

app.Run();
