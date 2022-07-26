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

        //clear the change tracker
        _context.ChangeTracker.Clear();

        return poke;
    }

    public bool DeletePokemon(int pokeId)
    {
        Pokemon? pokemonToDelete = _context.Pokemons.AsNoTracking().FirstOrDefault(p => p.Id == pokeId);
        if(pokemonToDelete != null) 
        {
            _context.Pokemons.Remove(pokemonToDelete);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
            return true;
        }
        return false;
    }

    public List<Pokemon> GetAllPokemons()
    {
        return _context.Pokemons.AsNoTracking().ToList();
    }

    public Pokemon GetPokemonByPokemonId(int pokemonId)
    {
        
        return _context.Pokemons.AsNoTracking().FirstOrDefault(p => p.Id == pokemonId) ?? throw new RecordNotFoundException("No pokemon was found with this id");
    }

    public List<Pokemon> GetPokemonsByTrainerId(int trainerId)
    {
        return _context.Pokemons.AsNoTracking().Where(p => p.TrainerId == trainerId).ToList();
    }
}