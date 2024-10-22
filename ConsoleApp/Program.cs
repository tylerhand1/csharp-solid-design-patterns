// Coupling

using ConsoleApp.src.OopPrinciples.Coupling;

var order = new Order(new SmsSender());
order.PlaceOrder();