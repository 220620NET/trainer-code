using Models;
using DataAccess;

namespace Services;

public class PokeService
{

    public void Register(PokeTrainer trainerToRegister)
    {
        //This method takes in the new trainer to be registered, and adds it to the registry
        PokeStorage.TrainerRegistry[PokeStorage.RegistrySize] = trainerToRegister;
        PokeStorage.RegistrySize++;
    }

    /// <summary>
    /// This method finds a trainer with the given name from PokeStorage static class
    /// </summary>
    /// <returns>Found trainer</returns>
    public PokeTrainer FindTrainer(Predicate<PokeTrainer> searchCriteria)
    {
        try 
        {
            return Array.Find(PokeStorage.TrainerRegistry, searchCriteria);
        }
        catch(ArgumentNullException ex)
        {
            throw;
        }
    }
}