using RentalSystem.ItemClasses;
using RentalSystem.UserClasses;

namespace RentalSystem.RentClasses;

public class RentSystem
{
    private List<RentEntry> _entries { get; set; }
    public List<RentEntry> entries => _entries;
    private List<User> _users { get; set; }
    private List<Item> _items { get; set; }

    public RentSystem()
    {
        _entries = new List<RentEntry>();
        _users = new List<User>();
        _items = new List<Item>();
    }

    public List<Item> getItemList()
    {
        return _items;
    }

    public List<Item> getItemList(Availability availability)
    {
        List<Item> filteredItems = new List<Item>();
        foreach (Item item in _items)
        {
            if (item.availability == availability)
            {
                filteredItems.Add(item);   
            }
        }
        return filteredItems;
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

        if (_users.Contains(user) && _items.Contains(item))
        {
            if (userEntries.Count - getStatusEntries(userEntries, Status.COMPLETED).Count <= user.rentLimit)
            {
                if (item.availability == Availability.AVAILABLE)
                {
                    RentEntry entry = new RentEntry(user, item, "", "");
                    entries.Add(entry);
                }
                else
                {
                    Console.WriteLine("Item unavailable");
                }
            }
            else
            {
                Console.WriteLine("User reached rent limit");
            }
        }
        else
        {
            Console.WriteLine("No such user/item in database");
        }
    }

    public void addNewUser(User newUser)
    {
        if (_users.Contains(newUser))
        {
            Console.WriteLine("User is already in system");
        }
        else
        {
            _users.Add(newUser);
        }
    }

    public void addNewItem(Item newItem)
    {
        if (_items.Contains(newItem))
        {
            Console.WriteLine("Item is already in system");
        }
        else
        {
            _items.Add(newItem);
        }
    }
}