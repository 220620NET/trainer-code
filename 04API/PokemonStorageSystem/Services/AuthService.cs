using Models;
using System.Text.Json;
using DataAccess; 
using CustomExceptions;

namespace Services;
public class AuthService
{
    private readonly IPokemonTrainerRepository _repo;

    //dependency injection
    public AuthService(IPokemonTrainerRepository repository)
    {
        _repo = repository;
    }
    public PokeTrainer Register(PokeTrainer newTrainer)
    {
        //if you want to keep your name unique in your registry, you can check for duplicates
        //if there is no duplicate record found, then we save this new trainer to our data layer- somewhere
        //First, I need to get the registry, and add it there and then save the new dictionary/collection
        try
        {
            _repo.GetPokeTrainer(newTrainer.Name);
            throw new DuplicateRecordException();
        }
        catch(RecordNotFoundException)
        {
            //we are g2g with registration
            Console.WriteLine("We didn't find the record");
            return _repo.AddPokeTrainer(newTrainer);
        }
    }

}
