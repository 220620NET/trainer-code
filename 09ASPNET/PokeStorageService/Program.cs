using Services;
using CustomExceptions;
using DataAccess;
using Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowAllHeadersPolicy",
        builder =>
        {
            builder.WithOrigins("*")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<PokeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EFCorePokeDB")));

builder.Services.AddScoped<IPokemonTrainerRepository, EFCPokeTrainerRepo>();
builder.Services.AddScoped<IPokemonRepository, EFCPokemonRepo>();

//----------Services---------------
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<PokeTrainerService>();
builder.Services.AddScoped<PokemonService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyAllowAllHeadersPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program{ }