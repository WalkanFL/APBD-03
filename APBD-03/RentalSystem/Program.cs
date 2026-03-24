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

rentSystem.addNewEntry(stud2, lap1);
rentSystem.addNewEntry(stud2, lap2);
rentSystem.addNewEntry(stud2, micro1);

void displayItemList(List<Item> items)
{
    foreach (Item item in items)
    {
        Console.WriteLine(item.id + " " + item.name + " : " + item.availability);
    }
}
void displayRentList(List<RentEntry> rentEntries)
{
    foreach (RentEntry entry in rentEntries)
    {
        Console.WriteLine(
            "Who: "+ entry.who.id + " " + entry.who.fullname + "\n" +
            "What: "+ entry.what.id + " " + entry.what.name  +"\n" +
            "Status: "+ entry.entryStatus
            );
    }
}

displayItemList(rentSystem.getItemList());
displayItemList(rentSystem.getItemList(Availability.AVAILABLE));

displayRentList(rentSystem.entries);
displayRentList(rentSystem.getUsersEntries(rentSystem.entries, stud2));
displayRentList(rentSystem.getStatusEntries(rentSystem.entries, Status.OVERDUE));

RentEntry stud2sRegEntry = rentSystem.getUsersEntries(rentSystem.getStatusEntries(rentSystem.entries), stud2).First();
rentSystem.entries.Last().forceOverdue();
RentEntry stud2sOverEntry = rentSystem.getUsersEntries(rentSystem.getStatusEntries(rentSystem.entries, Status.OVERDUE), stud2).First();

stud2sRegEntry.completeEntry();
stud2sOverEntry.completeEntry();

rentSystem.generateReport();