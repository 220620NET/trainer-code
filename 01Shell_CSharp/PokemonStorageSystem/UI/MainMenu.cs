using DataAccess;
using Services;
using Models;
//in my main menu, I want to put all my user interaction/ user interface stuff here.
//This is an example of separation of concerns where instead of creating a one big generalist class that handles EVERYTHING, we create multiple small specialist classes that does one thing each
//Creating classes/namespaces to hold related data and/or behaviors together is an example of encapsulation (this is one of 4 principles of OOP)
namespace UI;

public class MainMenu
{
    public void Start()
    {
        do
        {
            Console.WriteLine("Welcome to Pokemon Storage System");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[x] Exit");
            string input = Console.ReadLine();

            //I could do if/elseif/else here that would be equally valid
            switch(input)
            {
                case "1":
                    //log in
                break;
                case "2":
                    //register
                    Console.WriteLine("Registering a new trainer");
                    Console.WriteLine("What is Your Name?");
                    string name = Console.ReadLine();
                    PokeTrainer newTrainer = new PokeTrainer();
                    newTrainer.SetName(name);

                    Console.WriteLine("How many badges to you have?");
                    string numBadges = Console.ReadLine();
                    int intBadges = Int32.Parse(numBadges);
                    newTrainer.NumBadges = intBadges;

                    new PokeService().Register(newTrainer);
                    for(int i = 0; i < PokeStorage.TrainerRegistry.Length; i++)
                    {
                        if(PokeStorage.TrainerRegistry[i] != null)
                        {
                            Console.WriteLine(PokeStorage.TrainerRegistry[i].GetName());
                        }
                    }
                break;
                case "x":
                    Console.WriteLine("goodbye, see you again soon!");
                    System.Environment.Exit(0);
                break;
                default:
                    //Here, we handle scenarios where the user input matched none of our cases
                    Console.WriteLine("I don't understand your input");
                break;
            }

        } while(true);
    }
}