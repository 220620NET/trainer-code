using Models;
using System.Text.Json;
using DataAccess; 
using CustomExceptions;

namespace Services;
public class AuthService
{
    public PokeTrainer Register(PokeTrainer newTrainer)
    {
        //if you want to keep your name unique in your registry, you can check for duplicates
        //if there is no duplicate record found, then we save this new trainer to our data layer- somewhere
        //First, I need to get the registry, and add it there and then save the new dictionary/collection
        try
        {
            PokeTrainer duplicateCheck = new PokeTrainerRepository().GetTrainerByName(newTrainer.Name);
            if(duplicateCheck != null)
            {
                throw new DuplicateRecordException();
            }
            return new PokeTrainerRepository().AddPokeTrainer(newTrainer);
        }
        catch(JsonException)
        {
            throw;
        }
    }

}
