using UI;
using Services;
using DataAccess;

//Dependency injection
await new MainMenu(new AuthService(new PokemonTrainerRepository())).Start();