using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ListaDeTarefas.Data;
using ListaDeTarefas;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ListaDeTarefasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ListaDeTarefasContext") ?? throw new InvalidOperationException("Connection string 'ListaDeTarefasContext' not found.")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapTarefaEndpoints();

app.Run();