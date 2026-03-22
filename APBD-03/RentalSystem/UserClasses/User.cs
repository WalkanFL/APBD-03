namespace RentalSystem.UserClasses;

public abstract class User
{
    private static int count = 0;
    
    private string _id { get; }
    public string id => _id;
    private string name { get; set; }
    private string surname { get; set; }
    protected int _rentLimit { get; set; }
    public int rentLimit => _rentLimit;

    public User(string name, string surname)
    {
        _id = "u" + Generator.generateNum(count);
        this.name = name;
        this.surname = surname;
    }
}