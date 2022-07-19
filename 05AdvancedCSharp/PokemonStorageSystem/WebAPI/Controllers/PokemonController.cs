using Models;
using Services;
using CustomExceptions;

namespace WebAPI.Controllers;

public class PokemonController
{
    private readonly PokemonService _service;

    public PokemonController(PokemonService service)
    {
        _service = service;
    }
    public IResult GetAllPokemons()
    {
        List<Pokemon> allPokes = _service.GetAllPokemons();
        
        return allPokes.Count > 0 ? Results.Ok(allPokes) : Results.NoContent();
    }

    public IResult GetPokemonsByTrainerId(int trainerId)
    {
        List<Pokemon> trainerPokes = _service.GetPokemonsByTrainerId(trainerId);

        return trainerPokes.Count > 0 ? Results.Ok(trainerPokes) : Results.NoContent();
    }

    public IResult WithdrawPokemon(int pokemonId)
    {
        try
        {
            return Results.Ok(_service.WithdrawPokemon(pokemonId));
        } 
        catch(RecordNotFoundException)
        {
            return Results.NoContent();
        }
    }

    public Pokemon DepositPokemon(Pokemon newPokemon)
    {
        return _service.DepositPokemon(newPokemon);
    }
}