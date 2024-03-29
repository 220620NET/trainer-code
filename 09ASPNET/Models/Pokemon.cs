using CustomExceptions;
using System.ComponentModel.DataAnnotations;

namespace Models;
public class Pokemon
{
    public Pokemon() {
        Name = "";
        // Level = 0;
        // TrainerId = 0;
        Type = "";
    }

    //constructor chaining
    public Pokemon(string name) : this()
    {
        Name = name;
        // _name = name;
    }
    //what kind of data should I hold here?
    //IE Strengh, Name, Level, Exp, Hp, TrainerWhoCaughtThisOne, Type, NickName

    [Required]
    public string Name { get; set; }
    // private string _name;
    // public string Name 
    // { 
    //     get
    //     {
    //         return _name;
    //     } 
    //     set
    //     {
    //         if(String.IsNullOrWhiteSpace(value))
    //         {
    //             throw new InputInvalidException("Name cannot be empty");
    //         }
    //         else if(value.Length == 0 && value.Length >= 100)
    //         {
    //             throw new InputInvalidException("Name cannot be longer than 100 characters");
    //         }
    //         else
    //         {
    //             _name = value;
    //         }
    //     }
    // }

    // private int _level;
    [Range(1, 99)]
    public int Level 
    { 
        get; set; 
        // get{ return _level; }
        // set
        // {
        //     if(value <= 0)
        //     {
        //         throw new InputInvalidException("Level cannot be less than 0");
        //     }
        //     else
        //     {
        //         _level = value;
        //     }
        // }
    }

    [Range(1, Int32.MaxValue)]
    public int TrainerId { get; set; }

    public string Type { get; set; }

    public string? Disposition { get; set; }

    public string? NickName { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} \nNickName: {NickName} \nType: {Type} \nName: {Name} \nLevel: {Level}";
    }
}