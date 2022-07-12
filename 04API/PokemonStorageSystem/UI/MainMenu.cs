using Models;
using Services;
using System.Text.Json;
using CustomExceptions;

namespace UI;

public class MainMenu
{
    public void Start()
    {
        Console.WriteLine("Welcome to Pokemon Storage System!");
        Console.WriteLine("One convenient place for all your pokemon storage needs!");

        while(true)
        {
            Console.WriteLine("Are you already registered with us? [y/n/exit]");
            //if yes, register as new user, if no, log in.

            //first, i'm going to get the user's input via readline
            //then i'll turn it into all lowercase, and i'll take the first letter of the string -> yes, y, Y, YES, Yep, yeah -> 'y'
            char userInput = Console.ReadLine().ToLower()[0];

            switch(userInput)
            {
                case 'y':
                    //take to login
                    Console.WriteLine("log in");
                break;
                
                case 'n':
                    //register
                    RegisterNewUser();
                break;

                case 'e':
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("idk what you're talkin' about");
                break;
            }
        }
    }

    //This is my private helper method.
    //I(This class) don't intend on anyone else using this but me (this main menu class) so I keep it private to myself
    //This encapsulates the register related logic to a method 
    private void RegisterNewUser()
    {
        Console.WriteLine("Registering a new user");
        Console.WriteLine("What's your name?");
        string username = Console.ReadLine();
        Console.WriteLine("How about your birthday?");
        //the problem here was that the readline gave a string, but i wanted to store it as DateOnly object. But there was no way to easily go from string to DateOnly
        // So we first converted the string to DateTime and then converted the DateTime to DateOnly 
        string dob = Console.ReadLine();
        DateTime birthDay = Convert.ToDateTime(dob);

        PokeTrainer registeringTrainer = new PokeTrainer{
            Name = username,
            DoB = birthDay
        };
        //UI's job is now done, we now send it off to actually be registered somewhere else.
        try
        {
            PokeTrainer trainer = new AuthService().Register(registeringTrainer);
            Console.WriteLine("Registered successfully!");
        }
        catch(JsonException ex)
        {
            Console.WriteLine("sorry, something happened with our database, please try again");
        }
        catch(DuplicateRecordException ex)
        {
            Console.WriteLine("Sorry, the name is already taken");
        }
    }
}