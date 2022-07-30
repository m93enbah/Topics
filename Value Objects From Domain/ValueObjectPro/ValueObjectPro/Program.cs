//if you want to interact the object as value type make the classess inherit with the ValueObject and implement the GetEqualityComponents which validate the value of these class not the insance
using ExamplePro2;

Console.WriteLine("Hello, World!");


//we here we are using class and using ValueObject To Convert the class and react as value type by provide the methods defined on Value Object

var one = new Address("1 Microsoft Way", "Redmond", "WA", "US", "98052");
var two = new Address("1 Microsoft Way", "Redmond", "WA", "US", "98052");

Console.WriteLine(EqualityComparer<Address>.Default.Equals(one, two)); // True
Console.WriteLine(object.Equals(one, two)); // True
Console.WriteLine(one.Equals(two)); // True
Console.WriteLine(one == two); // True

Console.ReadLine();