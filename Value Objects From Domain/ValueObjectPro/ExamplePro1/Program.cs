// See https://aka.ms/new-console-template for more information
using ExamplePro1;

var cust1 = new Customer();
cust1.CustomerId = Guid.NewGuid();
cust1.Name = "Ali Ahmad";
cust1.Discount = 200;
cust1.Address = new AddressMain("1", "1", "1", "1", "1");

var cust2 = new Customer();
cust2.CustomerId = Guid.NewGuid();
cust2.Name = "Ali Ahmad";
cust2.Discount = 200;
cust2.Address = new AddressMain("1", "1", "1", "1", "1");

Console.WriteLine(cust1.Address == cust2.Address);

Console.ReadLine();