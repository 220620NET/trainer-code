/* Hangman
Hangman is a game where a user must guess a randomly picked word in a 6 tries
The user guesses a letter, then we can tell if it exists in the word or not.
If the letter exists in the word, then we fill the letter in.
User can also guess the word
*/

/*
Maybe I should give users option to 1. Guess a letter 2. Guess the word
and then depending on the result, i'll let them know accordingly
*/

/*
I want to have a word bank or a way to randomly choose a word
*/
//Array is a data structure that holds multiple data of the same type. They are fixed-length, so we need to set the length at initialization and when we run out of space, we create a new bigger array.

string[] wordBank = new string[14]{"apple", "pear", "phone", "avocado", "orange", "giraffe", "peanut", "mango", "platypus", "tomato", "sugar", "Lion", "tigers", "bears"};

// char[] listofCharacters = new char[26]();
// //[null, null, null, null, null, null, null, null, null, null, null, null, ...];
// wordBank[0] = "apple";
// wordBank[1] = "pear";
// wordBank[0] = "banana";
// wordBank = new string[20]();

//string is in fact, array of characters
//wordBank[0][1]; //'p'

//in C#, we use "" to denote strings, and '' to denote characters

//To select a random word, I want to pick a random number between 0 and 13 and grab the word in that index of wordBank
//I'll be using C#'s Random class to get myself a random number
Random randomNumGenerator = new Random();
int randomNumber = randomNumGenerator.Next(14); //This will get me a random integer between 0 and 13
string answer = wordBank[randomNumber];
int tries = 6;
char[] guess = new char[answer.Length];
Console.WriteLine("Welcome to Hangman");

while(tries > 0)
{
    Console.WriteLine("Currently the word has " + answer.Length + " letters");
    Console.WriteLine("Currently you have " + tries + " tries");
    Console.WriteLine(DisplayGuess(guess));

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[1] Guess a letter");
    Console.WriteLine("[2] Guess the word");
    string input = Console.ReadLine();
    if(input == "1")
    {
        // then I'll have them guess letter
        Console.WriteLine("Take a guess");
        // int charInput = Console.Read();
        // char userGuess = Convert.ToChar(charInput);

        string strInput = Console.ReadLine();
        char userGuess = strInput[0];

        bool isCorrect = GuessLetter(userGuess);
        if(isCorrect)
        {
            Console.WriteLine(DisplayGuess(guess));
            if(CheckComplete(guess))
            {
                Console.WriteLine("You won!");
                break;
            }
        }
        else
        {
            Console.WriteLine("That wasn't correct");
            tries--;
        }
    }
    else if(input == "2")
    {
        //then i'll have them guess the word
        Console.WriteLine("Take a guess");
        string finalGuess = Console.ReadLine();
        if(finalGuess == answer)
        {
            Console.WriteLine("You won!");
            break;
        }
        else
        {
            tries--;
            Console.WriteLine("That wasn't right");
        }
    }
    else
    {
        Console.WriteLine("I didn't understand the input");
    }

}
if(tries == 0)
{
    Console.WriteLine("You ran out of tries... ");
}

//This is a method. This encapsulates a behavior that we want to reuse
//This is the method signature, and it has 3 things; return type, method name, method parameters 
bool GuessLetter(char userGuess)
{   
    bool isCorrect = false;
    //I want to know if this character exists in the answer word

    //I want to loop through each character in my answer
    //and compare it to the user's guess
    //if it's the same, then i fill the guess array at that particular index
    //if it's not, then i just skip over

    for(int i = 0; i < answer.Length; i++)
    {
        if(answer[i] == userGuess)
        {
            guess[i] = userGuess;
            isCorrect = true;
        }
        //if the word is apple, and i guessed p,
        //then it will go and compare if a == p, if p == p, if p == p, if l == p, and if e == p
        //if it's true, then it will insert this 'p' character at the location where it was the character was true
        //because p == p at index 1 and 2
        //my guess array is going to be [null, p, p, null, null]
    }
    return isCorrect;
}

string DisplayGuess(char[] guessArr)
{
    string displayGuess = "";
    for(int i = 0; i < guess.Length; i++)
    {
        if(Char.IsLetter(guess[i]))
        {
            displayGuess += guess[i] + " ";
        }
        else
        {
            displayGuess += "_ ";
        }
    }
    return displayGuess;
}

bool CheckComplete(char[] guessArr)
{
    bool isComplete = true;
    for(int i = 0; i < guessArr.Length; i++)
    {
        if(!Char.IsLetter(guessArr[i]))
        {
            isComplete = false;
        }
    }
    return isComplete;
}