using Models;
using DataAccess;

namespace Services;

public class PokeService
{
    /// <summary>
    /// This method finds a trainer with the given name from PokeStorage static class
    /// </summary>
    /// <returns>Found trainer</returns>
    public PokeTrainer FindTrainer(Predicate<PokeTrainer> searchCriteria)
    {
        try 
        {
            Array.Find(PokeStorage.TrainerRegistry, searchCriteria);
        }
        catch(ArgumentNullException ex)
        {
            throw;
        }
    }
}