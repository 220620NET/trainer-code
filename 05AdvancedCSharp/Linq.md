# Extension Methods
This is a way to "inject" additional functionality to an existing class without creating new classes/types
LINQ provides all its functionality via extension methods 
In order to access the functionality of extension methods, all you have to do is include the namespace that the extension methods live in via using directive.
(ie: using System.Linq) 
- [MSDoc on Extension methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

# Lambda Expression
Is a shorthand to create anonymous functions/methods. The left hand side before the arrow is your method parameters, right hand side is your method body/return statement. These expressions are used extensively in LINQ method syntax. If you want to create multi line lambda expression or do operations before you return, you have to surround your right hand side with curly braces. Then, you have to be explicit about what you want to return.
```csharp
x => x * 2
```
or
```csharp
x => { 
    int y = x + x;
    return y;
    };
```

is equivalent to
```csharp
int DoubleThis(int x)
{
    return x * 2;
}
```