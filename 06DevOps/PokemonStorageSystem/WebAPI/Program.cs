using Services;
using CustomExceptions;
using DataAccess;
using Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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

// builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
// {
//     options.SerializerOptions.PropertyNamingPolicy = null;
// });

//dependency injection handled by ASP.NET Core
//Different ways to add your dependencies: Singleton, Scoped, Transient
//Singleton instances are shared throughtout the entire lifetime of the application
//Scoped instances are shared during the req/res lifecycle
//Transient instances are generated everytime it needs an instance of it
//--------- Data Access------------
//Our DbContext is Scoped --> aka, it is created for each and every request 
builder.Services.AddDbContext<PokeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PokeStorageDB")));
// builder.Services.AddSingleton<ConnectionFactory>(ctx => ConnectionFactory.GetInstance(builder.Configuration.GetConnectionString("PokeDB")));
builder.Services.AddScoped<IPokemonTrainerRepository, EFCPokeTrainerRepo>();
builder.Services.AddScoped<IPokemonRepository, EFCPokemonRepo>();

//----------Services---------------
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<PokeTrainerService>();
builder.Services.AddScoped<PokemonService>();


//----------Controllers------------
builder.Services.AddScoped<AuthController>();
builder.Services.AddScoped<PokemonTrainerController>();
builder.Services.AddScoped<PokemonController>();

//------------Swagger---------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseCors("MyAllowAllHeadersPolicy");

//-------------------------Auth Controller--------------------------
//When we ask for a reference type such as PokeTrainer as a payload
//the framework will expect to receive this in the request body
//The ASP.NET Core will take the json data and turn it into PokeTrainer
//using JsonSerializer from System.Text.Json namespace
app.MapPost("/auth/register", async (PokeTrainer trainer, [FromServices] AuthController controller) => await controller.Register(trainer));

/// <summary>
/// searches trainer by their name and returns trainer information if found
/// </summary>
/// <param name="trainerToLogin">PokeTrainer object with name (required)</param>
/// <returns>200 OK if trainer is found, 204 NoContent if there is no trainer, 400 BadRequest if the name is null</returns>
app.MapPost("/auth/login", async (PokeTrainer trainerToLogin, AuthController controller) => await controller.Login(trainerToLogin));


//------------------- Pokemon Trainer Controller -----------------------

/// <summary>
/// Returns all pokemon trainers in the db
/// </summary>
app.MapGet("/trainers", (PokemonTrainerController controller) => controller.GetAllTrainers());

//--------------------Pokemon Controller-------------------------

/// <summary>
/// Gets all pokemons
/// </summary>
/// <param name="trainerId">optional query parameter to filter results by trainer id</param>
/// <returns>200 OK with data if there is data, 204 NoContent if there is none</returns>
app.MapGet("/pokemon", (int? trainerId, PokemonController controller) => 
{
    if(trainerId == null)
    {
        return controller.GetAllPokemons();
    }
    else
    {
        return controller.GetPokemonsByTrainerId((int) trainerId);
    }
});


/// <summary>
/// Deposits a new pokemon to a particular trainer
/// </summary>
/// <param name="pokemonToDeposit">Pokemon object in json format, name and trainer id is required</param>
/// <returns>201 with Deposited Pokemon, 400 if either name or trainer id is missing</returns>
app.MapPost("/pokemon", ([FromBody] Pokemon pokemonToDeposit, PokemonController controller) => controller.DepositPokemon(pokemonToDeposit));

/// <summary>
/// Gets a specific pokemon by their id
/// </summary>
/// <param name="pokemonId">integer representation of a pokemon's unique id</param>
/// <returns>200 OK with pokemon data if found, if not 204 NoContent</returns>
app.MapGet("/pokemon/{pokemonId}",([FromRouteAttribute] int pokemonId, PokemonController controller) => controller.ViewPokemon(pokemonId));

app.MapDelete("/pokemon/{pokemonId}", (int pokemonId, PokemonController controller) => controller.WithdrawPokemon(pokemonId));

app.Run();
