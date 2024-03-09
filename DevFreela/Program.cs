using DevFreela.Application.Services.Implemetations;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConfiguration>(configuration);

builder.Services.AddSingleton<DevFreelaDbContext>();

builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
