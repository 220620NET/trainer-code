//Inheritance
// Mammal whodis = new Sheep();
// Sheep baa = (Sheep) whodis;
// baa.Shear();
// whodis = new Mammal();
// whodis = new Cat();

// //Traveling up and down the inheritance chain

// //UpCasting (implicit)
// Mammal warmBloodedMammal = new Sheep();
// // warmBloodedMammal = new Cat();
// // warmBloodedMammal.Shear(); //doesn't work

// Sheep actuallySheep = (Sheep) warmBloodedMammal;
// Console.WriteLine(actuallySheep.Shear()); // 4

// //DownCasting (explicit)
Animal baaa = new Sheep();
Sheep mySheep = (Sheep) baaa;

public abstract class Animal
{
    public Animal() {}

    protected TypeOfCoat CoatType { get; set; }
    public string Species { get; set; }

    //public getter, private setter
    public int NumberOfLimbs { get; private set; }

    //Example of using custom defined Enum
    //readonly does not allow changes after it has been initialized
    //similar to const
    
    //abstract method lacks the method body
    //It is implicitly virtual (aka overridable)
    // public abstract string MakeNoise();

    //This is a concrete method that is overridable
    //since it has virtual keyword
    public virtual string Move()
    {
        return "Animal moves";
    }
}

public enum TypeOfCoat { Feather, Fur, Scale, Wool }

public class Mammal : Animal
{
    public override string Move()
    {
        return "Mammal moves";
    }
}

public class Cat : Mammal 
{
    public override string Move()
    {
        return "Cat slinks";
    }
}

public class Sheep : Mammal {

    public Sheep()
    {
        this.CoatType = (TypeOfCoat) 3;
    }
    // public override string MakeNoise()
    // {
    //     return "baa";
    // }
    public override string ToString()
    {
        return "CoatType: " + CoatType;
    }

    public int Shear()
    {
        return 4;
    }
}
public class Barn {
    public Barn()
    {
        mySheep = new Sheep();
        // Console.WriteLine(mySheep.CoatType);
    }
    public Sheep mySheep { get; set; }
}