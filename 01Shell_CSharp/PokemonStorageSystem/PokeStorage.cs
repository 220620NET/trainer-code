using Models;

namespace DataAccess;

public static class PokeStorage
{
    public static PokeTrainer[] TrainerRegistry { get; set; } = new PokeTrainer[10];
}