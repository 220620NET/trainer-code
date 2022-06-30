# Inheritance

Inheritance is used to inherit a classes' members such as properties and methods to a child class, so a child class can have access to a parent's classes members. IE if animal has coatType and cat inherits animal, then cat also has coatType without having to define this on their own.

The primarily benefit of this is code reuse. Also we can use the inheritance chain to be flexible with our types during run time through up and down casting.

- Overriding
    - accomplished virtual and override modifiers, this allows a child class to provide its own behavior to the inherited parent's methods 
- Protected
    - is a access modifier that limits access to the class that defines it(whatever that it be) and the class's children
- Up/Downcasting through inheritance chain
    - We can assign a child class to act as a parent class -> because child has everything parent has (that are marked protected and public)