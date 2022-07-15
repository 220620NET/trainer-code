using Models;
using System.Text.Json;
using System.Text;
using CustomExceptions;
using System.Net.Http;

namespace UI;

public class MainMenu
{
    private readonly string api = "https://localhost:7278/";
    public MainMenu()
    {
    }
    public async Task Start()
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
                    await RegisterNewUser();
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
    private async Task RegisterNewUser()
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
            string serializedTrainer = JsonSerializer.Serialize(registeringTrainer);
            StringContent content = new StringContent(serializedTrainer, Encoding.UTF8, "application/json");
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.PostAsync(api + "register", content);

            if((int) response.StatusCode == 201)
            {
                //send http POST request to my backend(api) to do the job for me
                PokeTrainer trainer = JsonSerializer.Deserialize<PokeTrainer>(await response.Content.ReadAsStringAsync());
                Console.WriteLine("Registered successfully!");
                Console.WriteLine(trainer.Id + ": " + trainer.Name);
            }
            else if((int) response.StatusCode == 409)
            {
                Console.WriteLine("The username is already taken");
            }
            else if((int) response.StatusCode == 400)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                Console.WriteLine("Something is not quite right, please try again");
            }

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