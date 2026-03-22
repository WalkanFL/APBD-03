namespace RentalSystem.ItemClasses;

public class Microphone : Item
{
    private bool requiresMixer;
    private bool isAnalog;
    public Microphone(string name, double rentPrice, bool requiresMixer, bool isAnalog, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this.requiresMixer = requiresMixer;
        this.isAnalog = isAnalog;
    }
}