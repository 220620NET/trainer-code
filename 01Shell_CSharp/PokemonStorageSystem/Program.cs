using UI;

MainMenu menu = new MainMenu();
menu.Start();

// PokeTrainer trainer = new PokeTrainer();

// //Doesn't work, access denied
// // trainer.name = "Ash Ketchum";

// trainer.SetName("Ash Ketchum");


// Console.WriteLine(trainer.GetName());

// PokeTrainer anotherTrainer = new PokeTrainer("Brock");

// Console.WriteLine(anotherTrainer.GetName());

//Object Initializer
// int[] numArr = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// Console.WriteLine(numArr.ToString());

// PokeTrainer thirdTrainer = new PokeTrainer {
//     NumBadges = 3,
//     Money = 10,
// };

//Two Main Data Types in C#
//In C#, we have Value Type and Reference Type
//There are two different types of memory
//Stack, Heap
//Stack is a data structure that is Last In First Out and it also describes a type of memory/storage location where the program keeps reference to all your variables. 
//Data Types its values are stored in Stack is called "Value Types"
//Which means, in stack, it has the data type, the name, and the value
//if i were to declare int a = 3; The type (the fact that it's an 32bit integer), the name ('a'), and the value (3) are all stored in the stack
//In other cases, mostly commonly when the value is too big to store in stack, we store the value elsewhere (in the place called "Heap") and instead of the actual value in the stack, we store the address or where to go find the value in the heap. These types are called Reference Type.
//Examples of Value Types: any numbers (int, double, float, decimal, short, long, byte), bool, char, etc.
//Examples of Reference Types are: Classes, String (because string is an array of characters), any Collections (because these are in face classes), etc.

// PokeTrainer trainerA = new PokeTrainer();
// PokeTrainer trainerB = trainerA;

// Console.WriteLine(trainerA == trainerB);

// PokeTrainer trainerC = new PokeTrainer("trainer name");
// PokeTrainer trainerD = new PokeTrainer("trainer name");

// Console.WriteLine(trainerC == trainerD);

// Console.WriteLine(trainerD.ToString());

//Overloading vs Overriding
//These are examples of polymorphism, which is one of 4 OOP principles. 
/*
The difference between overloading and overriding is that for overloading, you overload a single method to take different PARAMETERS and return different types. This happens within a single class and the parameter must differ.
Overriding happens in an inheritance chain, where a child class overrides or implements a new behavior to a method it inherited from a parent class. The method to be overridden must have the non-access modifier 'virtual' to signify that it is over-rideable and when you implement a new behavior to your inherited method, you must use the non-access modifier 'override'. You must have the SAME parameter and return type for overriding methods.
Common methods we override are Object.ToString(), or Object.Equals() (to compare VALUES of reference types)  
*/

/*
Exceptions: they stand for "Exceptional Events" These are events that interrupt normal flow of the program. They are different from error because exceptions can be managed/handled where as errors are usual fatal.
Some examples of exception is "Null Reference Exception" which happens when I try to read a property or invoke a method of null, "Format Exception", "Stack Overflow", "File Not Found Exception", "Index Out of Range Exception".

We "Handle" these exceptions with Try/Catch block

First, we wrap our "risky" code (aka the code that might throw an exception) in a try block
And then, we follow that up with catch block, to catch any exceptions they throw and act accordingly.
Finally, there is a finally block to handle anything that needs to be managed before existing try/catch. IE Cleaning up resources that is not managed by your runtime such as closing connections. And this finally block is executed regardless of whether it caught an exception or not
*/

/*
There are many different types of exceptions for different scenarios. You want to use the appropriate type of exception to properly communicate to the rest of the program why it failed. However, all these exceptions actually inherit from Exception class.

And, if you find that there is no built in exception for the thing you're trying to do, you can create your own custom exception
*/

// try
// {
//     PokeTrainer testTrainer = new PokeTrainer();
//     testTrainer.SetName("     ");
// }
// catch(InputInvalidException ex)
// {
//     Console.WriteLine("Input Invalid Exception" + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("caught Exception" + ex.Message);
//     // throw;
// }
// finally
// {
//     Console.WriteLine("This is finally block");
// }

// try
// {
//     new PokeService().FindTrainer(null);
// }
// catch(ArgumentNullException ex)
// {
//     Console.WriteLine("Hey");
// }


// Cat auryn = new Cat();
// auryn.Speak();