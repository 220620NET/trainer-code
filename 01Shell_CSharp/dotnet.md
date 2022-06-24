# .NET

## .NET Platform
A full stack of services that lets you build many different type of application using variety of different programming languages.
.NET compliant languages include C#, F#, VB.NET
.NET Platform comprises of languages, frameworks (such as ASP.NET or Unity, or Mono), Libraries, etc.

## C# 
C# is a type-safe, Object Oriented Programming language
Type safe means that you have to be explicit about your data type at variable declaration
OOP means C# sees everything as an object and we build programs objects and building the relationship between those.
C# is a compiled language - which means that a piece of software goes through the program and converts it into a lower level code. Before you can run the program, you have to compile it first.

## SDK - Software Development Kit
SDK is Software Development Kit, which houses everything you need to be able to build and run a program using their technology, such as .NET SDK, JDK (for java).
SDK also includes Runtime. Runtime is a piece of software that contains tools to run the application (such as exception handling support, memory management, etc.)
In .NET, the runtime is called CLR(common language runtime)

## Code Editor vs IDE
VSCode is an example of the code editor, which is a souped up text editor with tools and capabilities to make coding easier and faster.

IDE: Integrated Development Environment
Is a piece of software that includes ALL tools you might want to develop a software in a certain technology. Visual Studio is the IDE for .NET, which means it comes bundled in SDK, Git support, deployment support, testing support, and so much more.

## dotnet cmds
- To create a new console application, `dotnet new console -n appName`
- `dotnet run` to run your program
    - dotnet run actually runs dotnet build under the hood -> dotnet build && dotnet run
- `dotnet build` to just compile your program
- make sure to actually be at the project folder before you execute any of these commands

## To Create Multi Project Application
1. Create an Empty Folder (and preferably name it the name of your application)
2. Create a Console C# Project (`dotnet new console -n project-name`) named UI (to interact with users)
3. Create 3 class library projects (`dotnet new classlib -n project-name`) named Models, DataAccess, Services (these are just suggestions, but they each play a different role in this application)
    - Class library projects don't generate .exe (executable) files. They are not meant to be run directly, but to be used by other projects.
4. Connect projects to each other by creating project references.
    1. If project A needs classes from project B, navigate to project A in terminal. (cd ...)
    2. run `dotnet add reference relative-path-to-the-project-B-folder` to add reference of project B to project A (ex. `dotnet add reference ../Models`)
5. Finally, Create a solution to package all these projects together
    - First navigate to the folder that is holding all these projects
    - run `dotnet new sln -n sln-name` to generate a new solution
    - then run `dotnet sln add relative-paths-to-project-folders` in order to register projects to the solution (IN THE FOLDER THAT IS CONTAINING THE SLN)
        - `dotnet sln add ../Models ../UI ../Services ../DataAccess`


## Interface
What if, for classes, we had to provide an instruction sheet?
- ie. These are functionalities available to this class

We use interface to enforce a certain set of behavior on a class that implements it

Interface is a type that acts as a contract to a set of public behavior
Which means, any class that _implements_ that particular interface MUST implement all of interface's methods

For Example, any classes that implement ICloneable interface must implement all of ICloneable's method, which there is one, Clone().
Which means, if I'm using a class that implements ICloneable, as a User I know I can call Clone method on this class.

Interface is similar to abstract class in that both of them can have methods that doesn't have body. Interface methods are inherently public and abstract (aka doesn't have method body). However, they are different because abstract classes can have a constructor where as interfaces don't.

Interfaces for the most part contains definition for public behaviors/traits

## Interface vs Abstract Classes
- In Interface, everything is implicitly public
- Abstract Class can have constructors
- Abstract Class can also have concrete members (concrete methods, properties)
    - Concrete method is a method with a method body
    - These are concrete methods
        - public void Speak() { Console.WriteLine("Meow");}
        - public void Speak() {}
    - This is an abstract method
        - The method only has the method signature (access mod, return type, method name, method parameter) and not the method body( the curly braces )
        - public void Speak();
- We can implement multiple interfaces where as we can only inherit one class
