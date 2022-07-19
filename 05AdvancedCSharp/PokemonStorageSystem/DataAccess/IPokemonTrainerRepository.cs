using Models;

namespace DataAccess;

public interface IPokemonTrainerRepository
{
    List<PokeTrainer> GetAllTrainers();

    Task<PokeTrainer> GetPokeTrainer(string name);

    PokeTrainer GetPokeTrainer(int id);

    PokeTrainer AddPokeTrainer(PokeTrainer newTrainerToRegister);
}