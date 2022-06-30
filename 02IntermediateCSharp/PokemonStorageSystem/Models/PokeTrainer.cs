using CustomExceptions;

//Namespace is analogous to packages in java, and it is a Logical collection of types, such as classes, enums, structs, etc.
namespace Models;

//Class is a blueprint to create objects
//public is an example of access modifier
//public means that everyone has access to whatever its decorating
public class PokeTrainer
{
    //Empty Constructor
    public PokeTrainer()
    {
        NumBadges = 0;
        Money = 0;
    }

    //This is constructor overloading
    public PokeTrainer(string trainerName)
    {
        NumBadges = 0;
        Money = 0;
        Name = trainerName;
    }

    public PokeTrainer(string trainerName, int badges)
    {
        Name = trainerName;
        NumBadges = badges;
        Money = 0;
    }

    private string _name;
    public string Name 
    { 
        get { return _name; }
        //C# provides the value user is trying to set this property with as a variable named "value" in the setter
        set
        {
            if(String.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Name must not be empty");
            }
            else //optional
            {
                _name = value;
            }
        }    
    }


    //automatic property or property for short. This is nothing more than a syntactic sugar over the above
    public int NumBadges { get; set; }

    public decimal Money { get; set; }

    //DateTime, TimeOnly, DateOnly, TimeSpan
    public DateTime DoB { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return $"Name: {this.Name} \nNumBadges: {this.NumBadges} \nMoney: {Money}";
    }
}