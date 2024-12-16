# Interface Segregation Principle

Clients should not be forced to depend on interfaces they do not use.

Interfaces should have only the methods required by the clients that use them.

For example, circle and sphere are both shapes, so they could implement a shape interface. However, this approach would require a circle to have a `Volume()` method. This requirement leads to messier and harder to maintain code. To fix this, the `Shape` interface can be segregated into two: `Shape2D` and `Shape3D`. For reference, see how Circle.cs and Sphere.cs implement these interfaces.