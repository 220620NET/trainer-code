// Console.WriteLine("Hello, World!");
// Console.WriteLine("What's your name?");

// string name = Console.ReadLine();

// // PascalCaseGoesLikeThis
// // camelCaseGoesLikeThis
// // These are comments, you create comments in C# by prefacing the line
// // with two slashes. These lines, do not get interpreted by compiler
// // Which is super useful to leave any notes for your future self and your teammates
// Console.WriteLine("Hello " + name + "!");

// //Different Operators
// // = : assignment operator
// int x = 3;
// int y = 5;
// // + is addition operator
// int z = x + y;
// Console.WriteLine(z); // 8
// // - subtraction operator
// // / division (be careful using this with integers as / with ints uses integer division ie, just gives you the quotient)
// Console.WriteLine(5 / 3);
// // * multiplication
// // % modulo operator -> this one gives you the remainder
// //Very useful in figuring out if int a is a multiple of int b,
// //as b % a == 0 if b is divisible by a
// Console.WriteLine(4 % 2); //result: 0
// Console.WriteLine(6 % 4); //result: 2

// // == equality operator, this one compares if the left value is the same as the right value and returns a boolean value(True or False)
// Console.WriteLine(2 == 5); //false
// Console.WriteLine(3 == 3); //true

// //Truth table
// // && AND
// Console.WriteLine(true && true); // true;
// Console.WriteLine(false && true); //false
// // || OR
// Console.WriteLine(true || false); //true

// //Basic Data Types
// //string, bool, int, double (for decimal #), long (a long int), byte, short (a short int), char (a single character), decimal
// //The ones you definitely want to be familiar with is string, bool, int, double

// //Conditional Statements: If/Else
// if(true)
// {
//     //act certain way
// }
// else
// {
//     //do something else
// }

// if(name == "juniper")
// {
//     Console.WriteLine("Hi Juniper!");
// }
// else
// {
//     Console.WriteLine("you're not juniper");
// }

// if(x < 0)
// {
//     Console.WriteLine("x is less than 0");
// }
// else if(0 < x && x < 10)
// {
//     Console.WriteLine("x is between 0 and 10");
// }
// else
// {
//     Console.WriteLine("x is greater than 10");
// }

// if(x % 2 == 0)
// {
//     Console.WriteLine("x is divisible by 2!");
// }
// else if(x % 3 == 0)
// {
//     Console.WriteLine("x is divisible by 3");
// }
// else
// {
//     Console.WriteLine("x is neither divisible by 2 or 3");
// }

// //For Loop
// int n = 1;
// //do stuff here
// n = n + 1;
// //do more stuff here
// n = n + 1;
// //do even more stuff here
// // Instead of ^
// // if you want to perform same action over and over for a certain number of times or until certain condition is met, we can use a loop!
// // for loop
// // create a new integer variable i and set it to 0,
// // while i is less than 100, so i from 0 to 99, execute the code block below
// // and every loop it executes, add 1 to i.

// for(int i = 0; i < 100; i++)
// {
//     Console.WriteLine(i);
// }

// /*
// This is multiline comment, or highlight a text block, and press ctrl + /
// */

// //For rest of today and until 11AM tomorrow, let's group up and write FizzBuzz program
// //This is simple program that will loop from 1 to a user defined number
// //that will print out the number on the screen
// //Except when the number is divisible by 3, it prints 'fizz'
// //and if the number is divisible by 5 it prints 'buzz'
// //and if the number is divisible by 3 and 5, it prints 'fizzbuzz'

// //First, ask the user to provide the end number
// //and then print from 1 to the end number, replacing multiples of 3 with fizz
// //and multiples of 5 with buzz
// // Fizzbuzz from 1 to 16
// //1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16

// //In order to convert from string to integer,
// //string input = Console.ReadLine();
// //int var = int.Parse(input);

//Given a number by user,
//I want to print them out from 1 to the number
//except if the # is multiple of 3, i print fizz, if it's multiple of 5, i print buzz, if multiple of 3 and 5 (it's multiple of 15) then i print fizzbuzz.

//10
//1 2 fizz 4 buzz fizz 7 8 fizz buzz

//First, I want to ask for the user's input
Console.WriteLine("Please Enter a number");
string userInput = Console.ReadLine();
//I'm going to parse this string to integer by using int.Parse() method that takes in a string and attempts to parse it. Here i'm going to blindly assume that the input i'm given is a string format of a number, not a character string, or an empty string.
int parsedInput = int.Parse(userInput);

for(int i = 0; i <= parsedInput; i++)
{
    if(i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}