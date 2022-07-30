namespace ExamplePro1
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public AddressMain Address { get; set; }
    }


    //we see that we are using record which is reference type react as value type so its not trackable and its equal true which the values are identical
    public record AddressMain(string Street, string City, string State, string Country, string PostalCode);
}
