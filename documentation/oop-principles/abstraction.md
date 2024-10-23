# Abstraction
It is an OOP pricinple used to reduce complexity by hiding unnecessary details of a class to a user of a class.

For example, a button on a TV remote abstracts interacting with a circuitboard to change a channel. All you really need to undestand is pressing a button.

Refer to ConsoleApp/src/OopPrincples/Abstraction for example of usage.

If a user had to call each method such as `Connect()`, they would have to update their program each time the `EmailService` was changed. Abstracting logic like `Connect()` and `Authenticate()` away simplifies the class for users where they only have to use `SendEmail()`.