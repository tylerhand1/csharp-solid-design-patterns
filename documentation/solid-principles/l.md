# Liskov Substitution Principle (LSP)

"Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program."

Inheritance hierarchies are well designed and subclasses adhere to contracts defined by their superclasses. Violating LSP can lead to unexpected behavior and errors when substituting objects.

As an example, the Square class can inherit from Rectangle because a square is a type of rectangle. However, this leads to issues when changing the type from Rectangle to Square, as the behavior changes when replacing a superclass with a subclass.

To resolve this and adhere to the Liskov Substitution Principle, the Square class can be redefined to inherit from the base Shape class.