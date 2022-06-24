using Models;

namespace DataAccess;

public static class PokeStorage
{
    public static PokeTrainer[] TrainerRegistry { get; set; } = new PokeTrainer[10];

    //this static property, keeps track of how full this array is.
    public static int RegistrySize { get; set; } = 0; 
}