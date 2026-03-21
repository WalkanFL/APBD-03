namespace RentalSystem.ItemClasses;

public class Camera : Item
{
    public Camera(string name, double rentPrice, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        
    }
}