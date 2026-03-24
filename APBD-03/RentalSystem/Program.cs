using RentalSystem.ItemClasses;
using RentalSystem.RentClasses;
using RentalSystem.UserClasses;
using OperatingSystem = RentalSystem.ItemClasses.OperatingSystem;

RentSystem rentSystem = new RentSystem();
Student stud1 = new Student("Studencjusz", "Pierwszus");
Student stud2 = new Student("Studenty", "Drugy");

Employee emp1 = new Employee("Pracek", "Jedynek");

Laptop lap1 = new Laptop("Lenovo",15, OperatingSystem.WINDOWS, 32);
Laptop lap2 = new Laptop("Maczek", 30, OperatingSystem.MAC, 64, Availability.DAMAGED);
Microphone micro1 = new Microphone("AT2020", 20, true, true);
Camera cam1 = new Camera("Cannon B16", 5,1200,1/6000, Availability.INREPAIR);

rentSystem.addNewUser(stud1);
rentSystem.addNewUser(stud2);
rentSystem.addNewUser(emp1);
//check
rentSystem.addNewUser(stud2);

rentSystem.addNewItem(lap1);
rentSystem.addNewItem(lap2);
rentSystem.addNewItem(micro1);
rentSystem.addNewItem(cam1);
//check
rentSystem.addNewItem(cam1);

rentSystem.addNewEntry(stud2, lap1, DateTime.Now.AddYears(77).ToLongDateString());
rentSystem.addNewEntry(stud2, lap2, DateTime.Now.AddMonths(7).ToLongDateString());
rentSystem.addNewEntry(stud2, micro1, DateTime.Now.ToLongDateString());

void displayItemList(List<Item> items)
{
    if (items.Count == 0)
    {
        Console.WriteLine("No such items");
    }
    else
    {
        Console.WriteLine("//////////////////////////////////////////////////////////////////////");
        foreach (Item item in items)
        {
            Console.WriteLine(item.id + " : " + item.name + " : " + item.availability);
        }
        Console.WriteLine("//////////////////////////////////////////////////////////////////////");
    }
}
void displayRentList(List<RentEntry> rentEntries)
{
    if (rentEntries.Count == 0)
    {
        Console.WriteLine("No such entries");
    }
    else
    {
        Console.WriteLine("//////////////////////////////////////////////////////////////////////");
        foreach (RentEntry entry in rentEntries)
        {
            Console.WriteLine(
                    "///////\n"+
                    "Who: "+ entry.who.id + " " + entry.who.fullname + "\n" +
                    "What: "+ entry.what.id + " " + entry.what.name  +"\n" +
                    "Status: "+ entry.entryStatus+
                    "\n///////"
                    );
        }
        Console.WriteLine("//////////////////////////////////////////////////////////////////////");
    }
    
}
Console.WriteLine("All Items");
displayItemList(rentSystem.getItemList());
Console.WriteLine("All Available Items");
displayItemList(rentSystem.getItemList(Availability.AVAILABLE));
Console.WriteLine("All Rent Entries");
displayRentList(rentSystem.entries);
Console.WriteLine("Only stud2 Rent Entries");
displayRentList(rentSystem.getUsersEntries(rentSystem.entries, stud2));
Console.WriteLine("Only Overdue Rent Entries");
displayRentList(rentSystem.getStatusEntries(rentSystem.entries, Status.OVERDUE));

RentEntry stud2sRegEntry = rentSystem.getUsersEntries(rentSystem.getStatusEntries(rentSystem.entries), stud2).First();
rentSystem.entries.Last().forceOverdue();
RentEntry stud2sOverEntry = rentSystem.getUsersEntries(rentSystem.getStatusEntries(rentSystem.entries, Status.OVERDUE), stud2).First();

stud2sRegEntry.completeEntry();
stud2sOverEntry.completeEntry();

Console.WriteLine("Report:");
rentSystem.generateReport();