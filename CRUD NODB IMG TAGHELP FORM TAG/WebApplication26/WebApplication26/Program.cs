using System;
using WebApplication26.Respository;
using WebApplication26.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Istudent , StudentService>();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();


app.UseMvcWithDefaultRoute();

app.UseStaticFiles();

app.Run();
