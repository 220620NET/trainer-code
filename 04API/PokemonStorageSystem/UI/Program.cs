using UI;
using Services;
using DataAccess;

//Dependency injection
new MainMenu(new AuthService(new PokemonTrainerRepository())).Start();