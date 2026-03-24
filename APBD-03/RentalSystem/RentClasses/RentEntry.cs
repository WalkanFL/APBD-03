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
    private bool _wasOverdue { get; set; }
    public bool wasOverdue => _wasOverdue;

    public RentEntry(User who, Item what, string when, string until)
    {
        _id = "r" + Generator.generateNum(count++);
        
        _who = who;
        _what = what;
        _when = when;
        _until = until;

        _entryStatus = Status.ONGOING;
        _wasOverdue = false;
    }
    public void checkForOverdue()
    {
        if (_entryStatus == Status.OVERDUE)//checks so we don't need to parse
        {
            return;
        }
        if (DateTime.Now > DateTime.Parse(_until))
        {
            _entryStatus = Status.OVERDUE;
            _wasOverdue = true;
        }
    }

    public void forceOverdue()
    {
        _entryStatus = Status.OVERDUE;
        _wasOverdue = true;
    }

    public void completeEntry()
    {
        double rentCost;
        checkForOverdue();
        if (_entryStatus == Status.OVERDUE)
        {
            int daysOverdue = (DateTime.Now - DateTime.Parse(_until)).Days;
            int daysRegular = (DateTime.Parse(_when) - DateTime.Parse(_until)).Days;
            
            rentCost = who.balance - (daysRegular + ( daysOverdue * what.overdueSeverity) * what.rentPrice);

        }
        else
        {
            int daysRegular = (DateTime.Parse(_when) - DateTime.Now).Days;
            rentCost = who.balance - (daysRegular * what.rentPrice);
        }
        who.setBalance(rentCost);
        _entryStatus = Status.COMPLETED;
        _what.setAvailability(Availability.AVAILABLE);

    }
}