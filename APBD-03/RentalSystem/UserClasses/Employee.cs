namespace RentalSystem.UserClasses;

public class Employee : User
{
    public Employee(string name, string surname) :  base(name, surname)
    {
        rentLimit = 5;
    }
}