namespace RentalSystem.UserClasses;

public abstract class User
{
    private static int count = 0;
    
    private string id { get; }
    private string name { get; set; }
    private string surname { get; set; }
    protected int rentLimit { get; set; }

    public User(string name, string surname)
    {
        id = "u" + Generator.generateNum(count);
        this.name = name;
        this.surname = surname;
    }
}