namespace RentalSystem.ItemClasses;

public abstract class Item
{
    public static int count = 0;
    private string id { get; }
    private string name { get; set; }
    
    private Availability _availability { get; set; }
    public Availability availability => _availability;
    
    private double _rentPrice { get; set; }
    public double rentPrice => _rentPrice;
    protected double _overdueSeverity { get; set; }
    public double overdueSeverity => _overdueSeverity;
    

    public Item(string name, double rentPrice, Availability availability = Availability.AVAILABLE)
    {
        id = "i" + Generator.generateNum(count);
        
        this.name = name;
        this._rentPrice = rentPrice;

        this._availability = availability;

    }
    public void changeAvailability(Availability newAvailability)
    {
        _availability = newAvailability;
    }
}