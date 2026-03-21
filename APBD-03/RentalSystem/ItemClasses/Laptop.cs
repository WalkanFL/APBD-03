namespace RentalSystem.ItemClasses;

public class Laptop : Item
{
    public Laptop(string name, double rentPrice, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        
    }
}