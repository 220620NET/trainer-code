using Models;
using Microsoft.EntityFrameworkCore;
using CustomExceptions;

namespace DataAccess;

public class EFCPokemonRepo : IPokemonRepository
{
    private readonly PokeDbContext _context;

    public EFCPokemonRepo(PokeDbContext context)
    {
        _context = context;
    }
    public Pokemon AddPokemon(Pokemon poke)
    {
        //EF Core can tell which class it is, so it is unnecessary to specify which dbSet you want this object to be added
        _context.Add(poke);
        _context.SaveChanges();

        return poke;
    }

    public bool DeletePokemon(int pokeId)
    {
        try
        {
            // Pokemon poke = _context.Pokemons.FirstOrDefault(p => p.Id == pokeId);
            // _context.Entry<Pokemon>(poke).State = EntityState.Deleted;
            _context.Remove(new Pokemon{Id = pokeId});
            _context.SaveChanges();
            return true;

        }
        catch
        {
            return false;
        }
    }

    public List<Pokemon> GetAllPokemons()
    {
        return _context.Pokemons.ToList();
    }

    public Pokemon GetPokemonByPokemonId(int pokemonId)
    {
        
        return _context.Pokemons.FirstOrDefault(p => p.Id == pokemonId) ?? throw new RecordNotFoundException("No pokemon was found with this id");
    }

    public List<Pokemon> GetPokemonsByTrainerId(int trainerId)
    {
        return _context.Pokemons.Where(p => p.TrainerId == trainerId).ToList();
    }
}