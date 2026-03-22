using RentalSystem.ItemClasses;
using RentalSystem.UserClasses;

namespace RentalSystem.RentClasses;

public class RentSystem
{
    private List<RentEntry> _entries { get; set; }
    public List<RentEntry> entries => _entries;

    public RentSystem()
    {
        _entries = new List<RentEntry>();
    }

    public List<RentEntry> getStatusEntries(List<RentEntry> list, Status status = Status.ONGOING)
    {
        List<RentEntry> statusEntries = new List<RentEntry>();
        
        foreach (RentEntry entry in list) {
            if (entry.entryStatus == status)
            {
                statusEntries.Add(entry);
            }
        }

        return statusEntries;
    }

    public List<RentEntry> getUsersEntries(List<RentEntry> list, User user)
    {
        List<RentEntry> users = new List<RentEntry>();
        
        foreach (RentEntry entry in list) {
            if (entry.who.id.Equals(user.id))
            {
                users.Add(entry);
            }
        }

        return users;
    }

    public void addNewEntry(User user, Item item)
    {
        List<RentEntry> userEntries = getUsersEntries(entries, user);
        
        if (userEntries.Count - getStatusEntries(userEntries, Status.COMPLETED).Count <= user.rentLimit)
        {
            if (item.availability == Availability.AVAILABLE)
            {
                RentEntry entry = new RentEntry(user, item, "", "");
                entries.Add(entry);
            }
        }
    }
}