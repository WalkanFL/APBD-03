namespace RentalSystem.ItemClasses;

public class Laptop : Item
{
    private OperatingSystem operatingSystem;
    private int gbStorage;
    
    public Laptop(string name, double rentPrice, OperatingSystem operatingSystem, int gbStorage, Availability availability = Availability.AVAILABLE) : base(name, rentPrice, availability)
    {
        this.operatingSystem = operatingSystem;
        this.gbStorage = gbStorage;
        _overdueSeverity = 3.5;
    }
}
public enum OperatingSystem
{
    WINDOWS,
    LINUX,
    MAC
}