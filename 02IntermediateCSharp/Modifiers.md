# Modifiers
## Access Modifiers
- Public 
    - Everything and everyone has access to it
    - Who has access to it?
        - Me (the class)
        - My children (the inheriting classes)
        - My household/roommates (the project/assembly that the class lives in)
        - Any and all strangers (other projects/assemblies)

- Private
    - Only I have access to it, no one else, not even my children

- Internal
    - Me
    - My housemates/roommates (things that live in the same project/assembly)

- Protected
    - Me (the class)
    - My children (all classes that inherit the class)

- By default, accessibility levels are
    - Internal for classes
    - Private for class members

## Non Access Modifiers

- Abstract Classes
    - Are classes that can contain abstract members

- Abstract Methods
    - means that there is no body (no behavior implemented)
    - Must be implemented by inheritor
    - Only abstract classes can have abstract methods

- Virtual
    - Mean it's overridable
    - Optional override since it has implementation

- readonly
    - you cannot modify this after initialization step
    - aka you can only assign a value to this in the constructor 

- const
    - you can set it but you can't change it EVER

- readonly vs const
    - const the value is determined at compile time/when you write code.
    - readonly the value can be determined at run time, but only during instantiation.