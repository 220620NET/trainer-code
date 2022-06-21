Console.WriteLine("Hello, World!");
Console.WriteLine("What's your name?");

string name = Console.ReadLine();

// PascalCaseGoesLikeThis
// camelCaseGoesLikeThis
// These are comments, you create comments in C# by prefacing the line
// with two slashes. These lines, do not get interpreted by compiler
// Which is super useful to leave any notes for your future self and your teammates
Console.WriteLine("Hello " + name + "!");

//Different Operators
// = : assignment operator
int x = 3;
int y = 5;
// + is addition operator
int z = x + y;
Console.WriteLine(z); // 8
// - subtraction operator
// / division (be careful using this with integers as / with ints uses integer division ie, just gives you the quotient)
Console.WriteLine(5 / 3);
// * multiplication
// % modulo operator -> this one gives you the remainder
//Very useful in figuring out if int a is a multiple of int b,
//as b % a == 0 if b is divisible by a
Console.WriteLine(4 % 2); //result: 0
Console.WriteLine(6 % 4); //result: 2

// == equality operator, this one compares if the left value is the same as the right value and returns a boolean value(True or False)
Console.WriteLine(2 == 5); //false
Console.WriteLine(3 == 3); //true

//Truth table
// && AND
Console.WriteLine(true && true); // true;
Console.WriteLine(false && true); //false
// || OR
Console.WriteLine(true || false); //true