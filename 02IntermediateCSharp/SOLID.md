# SOLID Principles

These are 5 design principles to consider so that we build software that are maintainable, flexible, and scalable

## Single Responsibility
Each classes should only have one and only one responsibility. ie. Do not create a mega class that tries to do everything

## Open Close
- Open to Extension but Closed to modification
- The class should be open to adding additional features in the future (scalable) but its previous features should be closed/protected from being modified

## Liskov Substitution Principle
All subtypes (or child classes) should be able to substitute its parent class.

## Interface Segregation
- Interfaces should not force its implementors (the classes that are implementing the interface) to implement methods that they don't need.

<!-- IDontDoThis (GetEnumerator, Clone)
Pokemon : IDontDoThis
<!-- IEnumerable (GetEnumertor)
IClonable (Clone) -->

## Dependency Inversion
- Concrete classes should depend on abstract definition. Concrete classes should inherit and implement abstract types such as abstract classes or interfaces.