namespace UI;

public interface IWalkable
{
    //this is implicitly public and abstract (aka doesn't have method body) (abstract is implicitly virtual)
    string Walk();
}

public interface ISpeakable
{
    string Speak();
}

public abstract class Mammal
{
    public Mammal() 
    {
        Console.WriteLine("Mammal Constructor");
    }
    public string SpecieName { get; set; }
}

public interface Animal
{

}

public class Cat : Mammal, Animal, IWalkable, ISpeakable
{
    public string Walk()
    {
        return "Cat Slinks";
    }

    public string Speak()
    {
        return "Meow";
    }
}

public class Dog : IWalkable, ISpeakable
{
    public string Walk()
    {
        return "doggo walks";
    }

    public string Speak()
    {
        return "Woof!";
    }
}