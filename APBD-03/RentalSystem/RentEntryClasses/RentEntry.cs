using RentalSystem.UserClasses;
using RentalSystem.ItemClasses;

namespace RentalSystem.RentEntryClasses;

public class RentEntry
{
    private static int count = 0;
    
    private string id { get; }

    
    private User who { get; }
    private Item what { get; }
    private string when { get; }
    private string until { get; }

    private Status entryStatus { get; set; }

    public RentEntry(User who, Item what, string when, string until)
    {
        id = "r" + Generator.generateNum(count);
        
        this.who = who;
        this.what = what;
        this.when = when;
        this.until = until;

        entryStatus = Status.ONGOING;
    }
}