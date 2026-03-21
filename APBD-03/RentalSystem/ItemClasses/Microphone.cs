namespace RentalSystem.ItemClasses;

public class Microphone : Item
{
    public Microphone(string name, double rentPrice, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        
    }
}