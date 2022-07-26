using Models;
using Microsoft.EntityFrameworkCore;
using CustomExceptions;

namespace DataAccess;

public class EFCPokeTrainerRepo : IPokemonTrainerRepository
{
    private readonly PokeDbContext _context;

    public EFCPokeTrainerRepo(PokeDbContext context)
    {
        _context = context;
    }

    public PokeTrainer AddPokeTrainer(PokeTrainer newTrainerToRegister)
    {
        //Adds it to the changeTracker in dbContext
        _context.PokeTrainers.Add(newTrainerToRegister);

        //Persists everything added so far to the change tracker to the db
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        //return the newly registered pokemon trainer
        return newTrainerToRegister;
    }

    public List<PokeTrainer> GetAllTrainers()
    {
        return _context.PokeTrainers.AsNoTracking().ToList();
    }

    public async Task<PokeTrainer> GetPokeTrainer(string name)
    {
        //LINQ method, returning the first match where the pokemon trainer's Name property is equal to the name we're looking for
        PokeTrainer? foundTrainer = await _context.PokeTrainers.AsNoTracking().FirstOrDefaultAsync(trainer => trainer.Name == name);

        if(foundTrainer != null) return foundTrainer;

        throw new RecordNotFoundException("Could not find the pokemon trainer with such name");
    }

    public PokeTrainer GetPokeTrainer(int id)
    {
        PokeTrainer? foundTrainer = _context.PokeTrainers.AsNoTracking().FirstOrDefault(trainer => trainer.Id == id);

        if(foundTrainer != null) return foundTrainer;

        throw new RecordNotFoundException("Could not find the pokemon trainer with such id");
    }
}