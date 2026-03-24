namespace RentalSystem.ItemClasses;

public class Microphone : Item
{
    private bool _requiresMixer { get; set; }
    private bool _isAnalog { get; set; }

    public Microphone(string name, double rentPrice, bool _requiresMixer, bool _isAnalog, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this._requiresMixer = _requiresMixer;
        this._isAnalog = _isAnalog;
        _overdueSeverity = 1.5;
    }
}