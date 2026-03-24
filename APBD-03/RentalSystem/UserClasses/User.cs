namespace RentalSystem.UserClasses;

public abstract class User
{
    private static int count = 0;
    
    private string _id { get; }
    public string id => _id;
    
    private string _name { get; set; }
    public string name => _name;
    private string _surname { get; set; }
    public string surname => _surname;
    public string fullname => _name + " " + _surname;
    
    protected int _rentLimit { get; set; }
    public int rentLimit => _rentLimit;
    private double _balance { get; set; }
    public double balance => _balance;

    public User(string name, string surname)
    {
        _id = "u" + Generator.generateNum(count++);
        _name = name;
        _surname = surname;
    }

    public void setBalance(double newBalance)
    {
        _balance = newBalance;
    }
}