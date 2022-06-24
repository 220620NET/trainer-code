namespace Models;
public class Pokemon
{
    public Pokemon() {}

    //what kind of data should I hold here?
    //IE Strengh, Name, Level, Exp, Hp, TrainerWhoCaughtThisOne, Type, NickName
    public string Name { get; set; }

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