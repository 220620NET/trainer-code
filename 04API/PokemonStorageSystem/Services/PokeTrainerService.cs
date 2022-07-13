using Models;
using DataAccess;

namespace Services;
public class PokeTrainerService
{
    private readonly IPokemonTrainerRepository _repo;

    public PokeTrainerService(IPokemonTrainerRepository repo)
    {
        _repo = repo;
    }
    public List<PokeTrainer> GetAllTrainers()
    {
        return _repo.GetAllTrainers();
    }

}
