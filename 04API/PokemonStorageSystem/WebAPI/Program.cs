using Services;
using DataAccess;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ConnectionFactory>(ctx => ConnectionFactory.GetInstance(builder.Configuration.GetConnectionString("PokeDB")));
builder.Services.AddScoped<IPokemonTrainerRepository, PokemonTrainerRepository>();
builder.Services.AddScoped<AuthService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hi Auryn!");

//the curly braces are the route parameters 
app.MapGet("/greet/{name}", (string name) => {
    return $"Hi {name}!";
});

//Query parameter: these are key value pairs you pass in with your url after the question mark(?)
app.MapGet("/greet", (string name, string location) => {
    if(String.IsNullOrWhiteSpace(location))
        return $"Hello {name}";
    return $"Hello {name} from {location}";
});

app.MapGet("/eat", (string food) => $"Someone is eating {food}");

app.MapPost("/greet", (string name) => {
    return $"Hello {name}";
});

app.Run();
