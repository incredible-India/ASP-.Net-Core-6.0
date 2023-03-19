using _Istudnet.Data;
using _Istudnet.Models;
using _Istudnet.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddScoped<_student, studentService>();

#if DEBUG

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

//database connection

string? con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<studentContext>((builder) => builder.UseSqlServer(con));


var app = builder.Build();

app.UseMvcWithDefaultRoute();


app.Run();
