# 4 Object Oriented Programming Principles/Pillars

A PIE: Abstraction, Polymorphism, Inheritance, Encapsulation

## Abstraction
- Hiding unnecessary details from users
- Ex: light switch because it hides all wiring, complexity of electrical wiring, and provides users with a switch they can toggle. 
- ex: Computer, monitor, keyboard, any kind of tech devices... they are bundles of abstractions
- ex: vehicles
- ex: C# and other programming languages are also a form of abstraction, because it hides away... the machine code
- Abstract classes and interfaces -> because they don't take part in implementation or describing "how-to" but their functions in C# is to provide a simple interface for users to use.
    - Ex: Knowing that Lists, Queues, Dictionaries, etc implement IEnumerable allows me to use them in foreach loop to access the collection items one by one without really knowing what's going on under the hood on getting that next item
- Design patterns also an example of abstraction, ie: Repository design pattern

## Encapsulation
- Encapsulation keeps similar things together: namespaces, classes ("Data Wrapping")
- Data Hiding: We use access modifiers to restrict access to certain data that should not be accessible by others

### Abstraction vs Encapsulation?
"Abstraction and encapsulation are complementary concepts: abstraction focuses on the observable behavior of an object...encapsulation focuses on the implementation that gives rise to this behavior" - Grady Booch

## Polymorphism
- Poly + Morph = "many forms"
- It describes an object's ability to take many forms
- Everyday example: when we speak/act/behave differently depending on the situation I'm in (Code Switching)
- Method Overloading
    - When a method with the same name, accessibility, and return type have many different ways it can act depending on the parameter it receives
        - Console.WriteLine method
        - Convert class's methods
- Typecasting
    - We can view objects as different types
- Generics
    - No matter what I pass in ex: `List<int> List<string> List<PokeTrainer>` my class knows how to preserve all its behavior/methods and properties
- Method Overriding 
    - When the child class provides its own behavior to the method it inherited from the parent.

## Inheritance
Inheritance is an ability for an object to inherit from another. In these inheritance chains, the child class that inherits from another class, takes parent's properties, methods, and other members (that are not private). This is useful when you want to create some kind of hierarchy between objects or have a common set of behavior that many classes share.

### Overloading(Polymorphism) vs Overriding(Inheritance + Polymorphism)
- Overloading is done in a single class
    - the parameter must be different
- Overriding is done in an inheritance chain (between 2+ classes)
    - The overridable methods must be modified with virtual modifier
    - The overriding methods must be modified with the override modifier
    - The return type and the parameter must be the same