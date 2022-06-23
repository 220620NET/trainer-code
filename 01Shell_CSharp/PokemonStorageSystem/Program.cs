using Models;

PokeTrainer trainer = new PokeTrainer();

//Doesn't work, access denied
// trainer.name = "Ash Ketchum";

trainer.SetName("Ash Ketchum");
Console.WriteLine(trainer.GetName());