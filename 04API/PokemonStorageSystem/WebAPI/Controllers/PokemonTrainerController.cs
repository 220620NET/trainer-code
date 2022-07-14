using Services;
using Models;
using CustomExceptions;

namespace WebAPI.Controllers;
public class PokemonTrainerController
{
    private readonly PokeTrainerService _service;
    public PokemonTrainerController(PokeTrainerService service)
    {
        _service = service;
    }

    public List<PokeTrainer> GetAllTrainers()
    {
        return _service.GetAllTrainers();
    }
}
