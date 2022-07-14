using Services;
using CustomExceptions;
using DataAccess;
using Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

//dependency injection handled by ASP.NET Core
//Different ways to add your dependencies: Singleton, Scoped, Transient
//Singleton instances are shared throughtout the entire lifetime of the application
//Scoped instances are shared during the req/res lifecycle
//Transient instances are generated everytime it needs an instance of it
builder.Services.AddSingleton<ConnectionFactory>(ctx => ConnectionFactory.GetInstance(builder.Configuration.GetConnectionString("PokeDB")));
builder.Services.AddScoped<IPokemonTrainerRepository, PokemonTrainerRepository>();
builder.Services.AddTransient<AuthService>();
builder.Services.AddTransient<PokeTrainerService>();
builder.Services.AddScoped<AuthController>();
builder.Services.AddScoped<PokemonTrainerController>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hi Auryn!");

//the curly braces are the route parameters 
app.MapGet("/greet/{name}", ([FromRoute]string name) => {
    return $"Hi {name}!";
});

////Query parameter: these are key value pairs you pass in with your url after the question mark(?)
app.MapGet("/greet", ([FromQuery] string name, string location) =>
{
    if (String.IsNullOrWhiteSpace(location))
        return $"Hello {name}";
    return $"Hello {name} from {location}";
});

/// <summary>
/// Returns all pokemon trainers in the db
/// </summary>
app.MapGet("/trainers", (PokemonTrainerController controller) => controller.GetAllTrainers());

//When we ask for a reference type such as PokeTrainer as a payload
//the framework will expect to receive this in the request body
//The ASP.NET Core will take the json data and turn it into PokeTrainer
//using JsonSerializer from System.Text.Json namespace
app.MapPost("/register", (PokeTrainer trainer, [FromServices] AuthController controller) => controller.Register(trainer));

app.Run();
