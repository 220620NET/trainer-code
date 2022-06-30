using Models;
using System.Text.Json;
namespace DataAccess;
public class PokeTrainerRepository
{
    //this class is responsible for persisting the information

    //In this particular instance, we'll be using json file to persist our data.

    private const string filePath = "../DataAcess/trainerRegistry.json"; 

    public PokeTrainer AddPokeTrainer(PokeTrainer newTrainer)
    {
        string fileString = File.ReadAllText(filePath);

        //Here, i'm Deseralizing the string to a type of C# object that rest of the application can use
        //serialization is a process of converting data into stream of bytes to be transported elsewhere to be saved elsewhere.
        //In here, we are converting our C# objects to stream of bytes, so we can save it into a file.
        //The data can be serialized into byteStream, characterStream, etc.

        //In this particular line, I took the string that I read from the file, and then I Deserialized this back into C# object I(the program) know how to work with. The process of converting the string/bytes back into objects is called deserialization
        try
        {
            Dictionary<string, PokeTrainer> trainerRegistry = JsonSerializer.Deserialize<Dictionary<string, PokeTrainer>>(fileString);

            trainerRegistry.Add(newTrainer.Name, newTrainer);

            File.WriteAllText(filePath, JsonSerializer.Serialize(trainerRegistry));

            return newTrainer;
        }
        catch(JsonException)
        {
            throw;
        }
    }
}
