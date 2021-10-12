using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------------- Data Registration --------------");

        //type data string
        string fname, lname, fullName, address;

        DateTime birthdate = DateTime.Now;

        Console.Write("enter your first name: ");
        fname = Console.ReadLine();

        Console.Write("enter your last name: ");
        lname = Console.ReadLine();

        fullName = fname + " " + lname;

        Console.Write("enter your address: ");
        address = Console.ReadLine();

        Console.Write("enter your birthdate (dd/mm/yyyy): ");
        try
        {
            birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            TimeSpan age = DateTime.Today - birthdate;
            Console.WriteLine("------------- Data Registered! --------------");
            Console.WriteLine("Fullname: " + fullName);
            Console.WriteLine("Age: " + Math.Floor(age.Days / 365.255));
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Birthdate: " + birthdate.ToString("dd/MM/yyyy"));
        }
        catch (FormatException)
        {
            Console.WriteLine("birthdate is not in the correct format.", birthdate);
        }
    }
}