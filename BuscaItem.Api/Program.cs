using BuscaItem.Application.Services;
using BuscaItem.Domain.Interfaces;
using BuscaItem.Domain.Models;
using BuscaItem.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<INotebookRepository,NotebookRepository>();
builder.Services.AddScoped<NotebookService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
