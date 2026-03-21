namespace RentalSystem;

public class Generator
{
    private static int numLength = 6;
    public static string generateNum(int number)
    {
        string numAsString = number.ToString();
        while (numAsString.Length != numLength)
        {
            numAsString = "0" + numAsString;
        }

        return numAsString;
    }
}