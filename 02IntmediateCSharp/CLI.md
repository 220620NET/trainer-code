## Common Language Infrastructure
- This is a set of specification initially developed by Microsoft for .NET compliant languages to subscribe to. And this is what allows many different .NET compliant languages to work with each other

## Common Type System
- A type specifications that all .NET compliant/CLI languages must implement.
EX:
    Int32 a = 3;
    int a = 3;
    Int32.Parse() int.Parse()

    Int64 > long
    Int16 > short

## Common Language Runtime
- Is a runtime for all CLI languages, it translates the Intermediary Language to Native Code on execution using Just-In-Time compiler (JIT Compiler). It also provides services such as automatic memory management (garbage collection), exception handling, type safety.

![CLRProcess](https://i.ytimg.com/vi/gCHoBJf4htg/maxresdefault.jpg)

## MSBuild
- Microsoft Build Engine, and it work with the .csproj file (the xml file that comes with every C# project) to determine the build order between multiple projects that depend on each other, resolve package dependencies, turning various language features on and off, and determining which framework/.NET implementation we're writing for (.NET 6)

## CSPROJ file (C Sharp PROJ)
is an xml file that contains project dependencies, package dependencies, language features/properties, target framework...etc. It's the file MSBuild needs and works with. It is also a file that let's SDK know that that folder is a C# project