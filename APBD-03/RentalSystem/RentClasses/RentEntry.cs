using RentalSystem.ItemClasses;
using RentalSystem.UserClasses;

namespace RentalSystem.RentClasses;

public class RentEntry
{
    private static int count = 0;
    
    private string _id { get; }

    
    private User _who { get; }
    public User who => _who;
    private Item _what { get; }
    public Item what => _what;
    private string _when { get; }
    private string _until { get; }

    private Status _entryStatus { get; set; }
    public Status entryStatus => _entryStatus;

    public RentEntry(User who, Item what, string when, string until)
    {
        
        
        _id = "r" + Generator.generateNum(count);
        
        this._who = who;
        this._what = what;
        this._when = when;
        this._until = until;

        _entryStatus = Status.ONGOING;
    }
}