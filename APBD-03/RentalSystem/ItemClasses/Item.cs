namespace RentalSystem.ItemClasses;

public abstract class Item
{
    public static int count = 0;
    private string id { get; }
    private string name { get; set; }
    
    private Availability _availability { get; set; }
    public Availability availability => _availability;
    
    private double rentPrice { get; set; }

    public Item(string name, double rentPrice, Availability availability = Availability.AVAILABLE)
    {
        id = "i" + Generator.generateNum(count);
        
        this.name = name;
        this.rentPrice = rentPrice;

        this._availability = availability;

    }

}