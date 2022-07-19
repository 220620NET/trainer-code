# Nullable Types

Before .NET 6, your reference types used be by default nullable, and your value types used by non-nullable.
With reference types, their default value is null
With value types, their default value... depends. For numeric types, it's 0, for bool, false..
We can declare something is nullable type by putting a question mark after the type (ie. int?, Product?)
Nullable property in .csproj will enforce this with warnings.

- Using if statement to check for null
```csharp
string? input = Console.ReadLine();
char userInput;
if(input != null)
{
    userInput = input.ToLower()[0];
}
```

- Null Coalescing Operator (??)
```csharp
string input = Console.ReadLine() ?? "";
char userInput = input.ToLower()[0];
```

- Null Conditional Operator(?.)
    - Use this for calling method and reading properties of types that can be null. 
    - The program will not read props or call method if the lefthand side is null
    ```csharp
    Product prod = null;
    //will not throw null ref exception
    prod?.Name;

    //will throw null ref exception
    prod.Name;
    ```

- Ternary
    - Ternary is a shorthand for if/else statement
    - 
    ```csharp
    int a = int.Parse(Console.ReadLine() ?? "");
    int b;
    if(a == 0)
    {
        b = 1;
    }
    else
    {
        b = 2;
    }

    //condition ? ifcase : elsecase
    b = a == 0 ? 1 : 2;

    b = a == null ? 2 : 3;
    ```