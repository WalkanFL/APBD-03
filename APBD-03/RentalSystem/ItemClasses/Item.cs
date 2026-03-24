namespace RentalSystem.ItemClasses;

public abstract class Item
{
    public static int count = 0;
    private string _id { get; }
    public string id => _id;
    private string _name { get; set; }
    public string name => _name;
    
    private Availability _availability { get; set; }
    public Availability availability => _availability;
    
    private double _rentPrice { get; set; }
    public double rentPrice => _rentPrice;
    protected double _overdueSeverity { get; set; }
    public double overdueSeverity => _overdueSeverity;
    

    public Item(string name, double rentPrice, Availability availability = Availability.AVAILABLE)
    {
        _id = "i" + Generator.generateNum(count++);
        
        _name = name;
        _rentPrice = rentPrice;

        _availability = availability;

    }
    public void setAvailability(Availability newAvailability)
    {
        _availability = newAvailability;
    }
}