using Models;
using CustomExceptions;

namespace Tests;

public class PokemonTests
{
    [Fact]
    public void PokemonShouldSetValidLevel()
    {
        //AAA
        //Arrange
        //This is where we "arrange"/set up all our necessary objects
        Pokemon testPokemon = new Pokemon();
        int levelToSet = 3;
        //Act
        //We Act out our test scenario- in this case, we are setting the level with a valid data
        testPokemon.Level = levelToSet;

        //Assert
        //We assert that the output matches our expected behavior
        //When given a valid data, we expect the level of testPokemon to equal the levelToSet
        Assert.Equal(testPokemon.Level, levelToSet);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(-123)]
    public void PokemonShouldNotSetInvalidLevel(int invalidData)
    {
        //Arrange
        Pokemon testPoke = new Pokemon();

        //Act & Assert
        //This is using something called delegate
        //basically passing in a anonymous function as a parameter to Thorws method
        //Assert.Throws method will accept the function (or the lambda expression) as a parameter, and call it, and ensure that it actually throws the Input Invalid Exception. If the function throws that particular exception, the test will pass. If the function does not throw the expection, the test fails.
        Assert.Throws<InputInvalidException>(() => testPoke.Level = invalidData);
    }

    [Fact]
    public void PokemonShouldSetValidName()
    {
        //I want to set the name of pokemon to "test name"
        //And make sure the name of the pokemon is actually "test name"

        //Arrange
        Pokemon testPokemon = new Pokemon();
        string nameToSet = "Pikachu";

        //Act
        testPokemon.Name = nameToSet; 
        //Assert
        Assert.Equal(testPokemon.Name, nameToSet);
    }

    [Fact]
    public void PokemonToStringShouldOutputValidString()
    {
        //Arrange
        Pokemon testPoke = new Pokemon{
            Name = "Pikachu", 
            Level = 99, 
            Type = "Electric",
            Id = 1,
            TrainerId = 1,
            NickName = "Pika"
        };

        string expectedOutput = "Id: 1 \nNickName: Pika \nType: Electric \nName: Pikachu \nLevel: 99";

        //Act 
        string output = testPoke.ToString();

        //Assert
        Assert.Equal(output, expectedOutput);
    }
}