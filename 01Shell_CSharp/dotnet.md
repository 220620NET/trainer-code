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