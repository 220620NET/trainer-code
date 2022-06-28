using Models;
using CustomExceptions;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Pokemon Storage System!");
Console.WriteLine("One convenient place for all your pokemon storage needs!");

Pokemon testPokemon = new Pokemon();
// testPokemon.Name = "test pokemon name";

try
{
    testPokemon.Level = Int32.Parse(Console.ReadLine());
    // testPokemon.Level = -1;
}
catch(InputInvalidException ex)
{
    Console.WriteLine("Exception was thrown");
    Console.WriteLine(ex.Message);
}

Console.WriteLine(testPokemon);
