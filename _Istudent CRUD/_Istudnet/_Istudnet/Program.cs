using _Istudnet.Data;
using _Istudnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using _Istudnet.Repository;
using _Istudnet.Helper;
//using _Istudnet.Helper;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddScoped<_student, studentService>();
//builder.Services.AddScoped<>(mycustomeValidation);

#if DEBUG

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

//database connection

string? con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<studentContext>((builder) => builder.UseSqlServer(con));


var app = builder.Build();

app.UseMvcWithDefaultRoute();


app.Run();
