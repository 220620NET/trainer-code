using Models;
using DataAccess;
using CustomExceptions;

namespace Services;

public class PokemonService
{
    private readonly IPokemonRepository _repo;

    public PokemonService(IPokemonRepository repo)
    {
        _repo = repo;
    }
    public List<Pokemon> GetAllPokemons()
    {
        return _repo.GetAllPokemons();
    }

    /// <summary>
    /// returns all pokemons belonging to a particular trainer
    /// </summary>
    /// <param name="trainerId">id of the trainer to search for</param>
    /// <returns>List of pokemons to a particular trainer, an empty list if the trainer does not have any pokemons</returns>
    public List<Pokemon> GetPokemonsByTrainerId(int trainerId)
    {
        return _repo.GetPokemonsByTrainerId(trainerId);
    }

    public Pokemon WithdrawPokemon(int pokemonId)
    {   
        try
        {
            //first check if it exists in db, and because we are "withdrawing" from the storage, save the pokemon info so we can send it back to the user
            Pokemon poke = _repo.GetPokemonByPokemonId(pokemonId);

            //Then delete the pokemon
            _repo.DeletePokemon(pokemonId);

            //if we got here without catching record not found exception, we are guaranteed to have some kind of pokemon record
            return poke;
        }
        catch(RecordNotFoundException)
        {
            throw;
        }
    }

    public Pokemon DepositPokemon(Pokemon newPokemon)
    {
        return _repo.AddPokemon(newPokemon);
    }
}