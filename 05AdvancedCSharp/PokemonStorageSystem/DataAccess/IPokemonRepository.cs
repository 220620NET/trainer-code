using Models;

namespace DataAccess;
public interface IPokemonRepository
{
    public List<Pokemon> GetAllPokemons();

    public Pokemon GetPokemonByPokemonId(int pokemonId);

    /// <summary>
    /// Gets all pokemon by Trainer Id
    /// </summary>
    /// <param name="trainerId">int representation of trainer id</param>
    /// <returns>List of pokemons belonging to a particular pokemon traienr</returns>
    public List<Pokemon> GetPokemonsByTrainerId(int trainerId);

    public Pokemon AddPokemon(Pokemon poke);

    public bool DeletePokemon(int pokeId);
}