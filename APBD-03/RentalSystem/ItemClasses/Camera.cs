namespace RentalSystem.ItemClasses;

public class Camera : Item
{
    private int isoSensitivity;
    private float shutterSpeed;
    public Camera(string name, double rentPrice, int isoSensitivity, float shutterSpeed, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this.isoSensitivity = isoSensitivity;
        this.shutterSpeed = shutterSpeed;
        _overdueSeverity = 2;
    }
}