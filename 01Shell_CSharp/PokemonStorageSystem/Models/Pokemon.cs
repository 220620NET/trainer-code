namespace Models;
public class Pokemon
{
    public Pokemon() {}

    public Pokemon(string name)
    {
        pokemonName = name;
    }
    //what kind of data should I hold here?
    //IE Strengh, Name, Level, Exp, Hp, TrainerWhoCaughtThisOne, Type, NickName
    private string pokemonName;

    public string GetPokeName() { return pokemonName; }
    public void SetPokeName(string newName)
    {
        //I'm imposing a maximum and minimum length of name here to 0 to 100 characters
        if(pokemonName.Length > 0 && pokemonName.Length <= 100)
        {
            pokemonName = newName;
        }

        
    }
    public string Name 
    { 
        get
        {
            return Name;
        } 
        set
        {
            if(value.Length > 0 && value.Length <= 100)
            {
                Name = value;
            }
        } 
    }

    private int level;

    public int GetLevel() { return level; }
    public void SetLevel(int newLevel) { level = newLevel; }

    public int Level { get; set; }

    public int TrainerId { get; set; }

    public string Type { get; set; }

    public string NickName { get; set; }

    public int Id { get; set; }
}

// public class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal speaks");
//     }
// }

// public class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meow");
//     }
// }