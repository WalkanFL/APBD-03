namespace RentalSystem.ItemClasses;

public class Camera : Item
{
    private int _isoSensitivity { get; set; }
    private float _shutterSpeed { get; set; }

    public Camera(string name, double rentPrice, int _isoSensitivity, float _shutterSpeed, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this._isoSensitivity = _isoSensitivity;
        this._shutterSpeed = _shutterSpeed;
        _overdueSeverity = 2;
    }
}