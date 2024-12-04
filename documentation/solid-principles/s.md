# Single Responsibility Principle (SRP)

A class should only have one reason to change, so it should have only one responibility or purpose.

For example, in the User class, if it had the Username and Email fields as well as business logic like registering a user, it would violate this principle. This is because, there are two potential reasons to modify the class: changing fields and changing business logic.

To address this and adhere to SRP, a solution would be to create an additional class called UserService that strictly handles business logic.