namespace RentalSystem.ItemClasses;

public class Laptop : Item
{
    private OperatingSystem _operatingSystem { get; set; }
    private int _gbStorage { get; set; }

    public Laptop(string name, double rentPrice, OperatingSystem _operatingSystem, int _gbStorage, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this._operatingSystem = _operatingSystem;
        this._gbStorage = _gbStorage;
        _overdueSeverity = 3.5;
    }
}
public enum OperatingSystem
{
    WINDOWS,
    LINUX,
    MAC
}