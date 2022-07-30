namespace ExamplePro3
{
    public record Currency(string symbol) 
    {
        public static Currency CAD => new Currency("CAD");
        public static Currency USD => new Currency("USD");
    }

    public record Money(Currency currency,decimal amount);
}