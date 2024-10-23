# Composition
This principle involves creating complex objects by combining simpler ones or components, where each component object maintains its own state and behavior. Composition is a `has-a` relationship.

Refer to ConsoleApp/src/OopPrincples/Composition for example of composition by creating a Car class using class components like Engine and Seats.

## Composition vs Inheritance
### When to Use Composition
- When you need more flexibility in constructing objects by assembling smaller, reusable components
- When there is no clear `is-a` relationship between classes, but a `has-a` relationship is more appropriate
- When you want to avoid inheritance limitations: tight coupling, Fragile Base Class Problem, etc
### When to Use Inheritance
- When there is a clear `is-a` relationship between classes
- When you want to promote code reuse by inheriting properties and behaviors from existing classes
- When you want to leverage polymorphism to allow objects at different subclasses to be treated uniformly through their common superclass interface

## Fragile Base Class Problem
This is a software design issue that arrises in OOP when changes to a base class inadvertently break the functionality of derived classes. This occurs due to tight coupling between base and derived classes.
1) Inheritance Coupling: Inheritance creates strong coupling between base and derived classes
2) Limited Extensibility: The Fragile Base Class Problem limits the extensibility of software systems, as modifications to the base class can become increasingly risky and costly over time. Developers may avoid making necessary changes due to fear of breaking existing functionality.
### Mitigation Strategies
To mitigate this problem, software developers can use design principles such as Open/Closed Principle (OCP) and Dependency Inversion Principle (DIP), as well as design patters like Composition over Inheritance. These approaches promote loose coupling, encapsulation and modular design; thus, reducing the impact of changes in base classes.