namespace RentalSystem.ItemClasses;

public abstract class Item
{
    private string id { get; }
    private string name { get; set; }
    
    private Availability availability { get; set; }
    
    private double rentPrice { get; set; }

}