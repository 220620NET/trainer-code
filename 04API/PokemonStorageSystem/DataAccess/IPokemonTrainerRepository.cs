using Models;

namespace DataAccess;

public interface IPokemonTrainerRepository
{
    List<PokeTrainer> GetAllTrainers();

    PokeTrainer GetPokeTrainer(string name);

    PokeTrainer GetPokeTrainer(int id);

    PokeTrainer AddPokeTrainer(PokeTrainer newTrainerToRegister);
}