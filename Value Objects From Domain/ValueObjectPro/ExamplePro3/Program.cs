// See https://aka.ms/new-console-template for more information
using ExamplePro3;

Console.WriteLine("Hello, World!");

var money1 = new Money(Currency.CAD, 1000);
var money2 = new Money(Currency.CAD, 1000);


Console.WriteLine(money1 == money2);
